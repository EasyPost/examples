PYTHON_BINARY := python3
PYTHON_VIRTUAL_ENV := venv
PYTHON_VIRTUAL_BIN := $(PYTHON_VIRTUAL_ENV)/bin
GO_BIN := $(shell go env GOPATH)/bin

## help - Display help about make targets for this Makefile
help:
	@cat Makefile | grep '^## ' --color=never | cut -c4- | sed -e "`printf 's/ - /\t- /;'`" | column -s "`printf '\t'`" -t

## clean - Remove the virtual environment and clear out .pyc files along with node_modules and vendor folders
clean: | clean-go clean-java clean-node clean-php clean-python

## clean-go - Cleans the Go environment
clean-go:
	rm -rf vendor

## clean-java - Cleans the Java environment
clean-java:
	rm -rf target
	find . -name '*.jar' -delete

## clean-python - Cleans the Python environment
clean-python:
	rm -rf $(PYTHON_VIRTUAL_ENV) dist *.egg-info .coverage
	find . -name '*.pyc' -delete

## clean-node - Cleans the Node environment
clean-node:
	rm -rf node_modules

## clean-php - Cleans the PHP environment
clean-php:
	rm -rf vendor bin

## install - install all dependencies for each language
install: | install-csharp install-go install-java install-node install-php install-python install-ruby

## install-csharp - install C# dependencies
install-csharp:
	sh ./symlink_directory_files.sh style_guides/csharp .
	dotnet tool install -g dotnet-format || exit 0

## install-go - Install and vendor Go dependencies
install-go:
	sh ./symlink_directory_files.sh style_guides/golang .
	curl -sSfL https://raw.githubusercontent.com/golangci/golangci-lint/master/install.sh | sh -s -- -b $(GO_BIN) v1.59.1
	go mod vendor

## install-java - installs Java dependencies
install-java:
	sh ./symlink_directory_files.sh style_guides/java .
	curl -LJs https://github.com/checkstyle/checkstyle/releases/download/checkstyle-10.3.1/checkstyle-10.3.1-all.jar -o checkstyle.jar
	mvn dependency:resolve

## install-node - installs Node dependencies
install-node:
	sh ./symlink_directory_files.sh style_guides/node .
	npm install

## install-php - installs PHP dependencies
install-php:
	sh ./symlink_directory_files.sh style_guides/php .
	composer install

## install-python - install Python dependencies
install-python:
	sh ./symlink_directory_files.sh style_guides/python .
	$(PYTHON_BINARY) -m venv $(PYTHON_VIRTUAL_ENV)
	$(PYTHON_VIRTUAL_BIN)/pip install -e ."[dev]"

## install-ruby - installs Ruby dependencies
install-ruby:
	sh ./symlink_directory_files.sh style_guides/ruby .
	bundle install

## lint - lints the entire project
lint: | lint-csharp lint-go lint-java lint-node lint-php lint-python lint-ruby lint-shell

## lint-csharp - lint C# files
lint-csharp:
	dotnet format whitespace --include official/docs/csharp/ --folder --verify-no-changes
	dotnet format whitespace --include official/guides/ --folder --verify-no-changes

## lint-go - Lint Go files
lint-go:
	$(GO_BIN)/golangci-lint run

## lint-java - lints Java files
lint-java:
	java -jar checkstyle.jar src -c easypost_java_style.xml -d official/docs/java/*
	java -jar checkstyle.jar src -c easypost_java_style.xml -d official/guides/*

## lint-node - lints Node files
lint-node:
	npm run lint

## lint-php - lints PHP files
lint-php:
	composer lint

## lint-python - lint Python files
lint-python:
	$(PYTHON_VIRTUAL_BIN)/flake8 official/docs/python/
	$(PYTHON_VIRTUAL_BIN)/flake8 official/guides/
	$(PYTHON_VIRTUAL_BIN)/flake8 official/landing_pages/

## lint-ruby - lints Ruby files
lint-ruby:
	bundle exec rubocop

## lint-shell - lints shell files
lint-shell:
	shellcheck official/docs/curl/current/**/*.sh -e SC2148,SC2034
	shfmt -i 2 -d official/docs/curl
	shellcheck official/guides/**/curl/*.sh -e SC2148,SC2034
	shfmt -i 2 -d official/guides/**/curl

## format - formats the entire project
format: | format-csharp format-go format-java format-node format-php format-python format-ruby format-shell

## format-csharp - formats C# files
format-csharp:
	dotnet format whitespace --include official/docs/csharp/ --folder
	dotnet format whitespace --include official/guides/ --folder

## format-go - formats Go files
format-go:
	$(GO_BIN)/golangci-lint run --fix

## format-java - formats Java files
format-java:
	echo "Not implemented"

## format-node - formats Node files
format-node:
	npm run format

## format-php - formats PHP files
format-php:
	composer fix

## format-python - formats Python files
format-python:
	$(PYTHON_VIRTUAL_BIN)/black official/docs/python/
	$(PYTHON_VIRTUAL_BIN)/isort official/docs/python/ --lines-after-imports -1 --no-sections
	$(PYTHON_VIRTUAL_BIN)/black official/guides/
	$(PYTHON_VIRTUAL_BIN)/isort official/guides/ --lines-after-imports -1 --no-sections
	$(PYTHON_VIRTUAL_BIN)/black official/landing_pages/
	$(PYTHON_VIRTUAL_BIN)/isort official/landing_pages/ --lines-after-imports -1 --no-sections

## format-ruby - formats Ruby files
format-ruby:
	bundle exec rubocop -a

## format-shell - formats shell files
format-shell:
	shfmt -i 2 -w official/docs/curl/*
	shfmt -i 2 -w official/guides/**/curl/*

## format-node-check - checks that Node files conform to the correct format
format-node-check:
	npm run check

## format-python-check - checks that Python files conform to the correct format
format-python-check:
	$(PYTHON_VIRTUAL_BIN)/black official/docs/python/ --check
	$(PYTHON_VIRTUAL_BIN)/isort official/docs/python/ --lines-after-imports -1 --no-sections --check-only
	$(PYTHON_VIRTUAL_BIN)/black official/guides/ --check
	$(PYTHON_VIRTUAL_BIN)/isort official/guides/ --lines-after-imports -1 --no-sections --check-only
	$(PYTHON_VIRTUAL_BIN)/black official/landing_pages/ --check
	$(PYTHON_VIRTUAL_BIN)/isort official/landing_pages/ --lines-after-imports -1 --no-sections --check-only

.PHONY: help install install-csharp install-go install-java install-node install-php install-python install-ruby install-shell lint lint-csharp lint-go lint-java lint-node lint-php lint-python lint-ruby lint-shell format format-csharp format-go format-java format-node format-php format-python format-ruby format-shell format-node-check format-python-check
