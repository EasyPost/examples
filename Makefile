PYTHON_BINARY := python3
PYTHON_VIRTUAL_ENV := venv
PYTHON_VIRTUAL_BIN := $(PYTHON_VIRTUAL_ENV)/bin


## help - Display help about make targets for this Makefile
help:
	@cat Makefile | grep '^## ' --color=never | cut -c4- | sed -e "`printf 's/ - /\t- /;'`" | column -s "`printf '\t'`" -t

## install - install all dependencies for each language
install: | install-csharp install-java install-node install-python install-ruby

## install-csharp - install C# dependencies
install-csharp:
	dotnet tool install -g dotnet-format

## install-go - Install and vendor Go dependencies
install-go:
	go mod vendor
	go build -o $(PROJECT_PATH)

## install-java - installs Java dependencies
install-java:
    # install CheckStyle jar for running locally
	wget -O checkstyle.jar -q https://github.com/checkstyle/checkstyle/releases/download/checkstyle-10.3.1/checkstyle-10.3.1-all.jar
    # download EasyPost stylesheet, use local style suppressions
	wget -O easypost_java_style.xml -q https://raw.githubusercontent.com/EasyPost/easypost-java/master/easypost_java_style.xml

## install-node - installs Node dependencies
install-node:
	npm install

## install-php - installs PHP dependencies
install-php:
	composer install

## install-python - install Python dependencies
install-python:
	$(PYTHON_BINARY) -m venv $(PYTHON_VIRTUAL_ENV)
	$(PYTHON_VIRTUAL_BIN)/pip install -r requirements.txt

## install-ruby - installs Ruby dependencies
install-ruby:
	bundle install

## lint - lints the entire project
lint: | lint-csharp lint-java lint-ruby lint-shell

## lint-csharp - lint C# files
lint-csharp:
    # clean up whitespace formatting
    # folder options skip looking for a project/solution, just analyze any *.cs file
	dotnet format whitespace --include official/docs/csharp/ --folder --verify-no-changes
	dotnet format whitespace --include official/guides/csharp/ --folder --verify-no-changes

## lint-go - Lint Go files
lint-go:
	golangci-lint run

## lint-java - lints Java files
lint-java:
	java -jar checkstyle.jar src -c easypost_java_style.xml -d official/docs/java/
	java -jar checkstyle.jar src -c easypost_java_style.xml -d official/guides/java/

## lint-node - lints Node files
lint-node:
	npm run lint

## lint-php - lints PHP files
lint-php:
	composer lint

## lint-python - lint Python files
lint-python:
	$(PYTHON_VIRTUAL_BIN)/flake8 official/docs/python/

## lint-ruby - lints Ruby files
lint-ruby:
	rubocop

## lint-shell - lints shell files
lint-shell:
	shellcheck official/docs/curl/**/*.sh -e SC2148
	shellcheck official/guides/curl/**/*.sh -e SC2148
	shfmt -i 2 -d official/docs/curl
	shfmt -i 2 -d official/guides/curl

## format - formats the entire project
format: | format-csharp format-java format-ruby format-shell

## format-csharp - formats C# files
format-csharp:
    # clean up whitespace formatting
    # folder options skip looking for a project/solution, just analyze any *.cs file
	dotnet format whitespace --include official/docs/csharp/ --folder
	dotnet format whitespace --include official/guides/csharp/ --folder

## format-go - formats Go files
format-go:
	golangci-lint run --fix

## format-java - formats Java files
format-java:
	echo "Not implemented"

## format-node - formats Node files
format-node:
	npm run format

## format-node-check - checks that Node files conform to the correct format
format-node-check:
	npm run check

## format-python - formats Python files
format-python:
	$(PYTHON_VIRTUAL_BIN)/black official/docs/python/
	$(PYTHON_VIRTUAL_BIN)/isort official/docs/python/

## format-python-check - checks that Python files conform to the correct format
format-python-check:
	$(PYTHON_VIRTUAL_BIN)/black official/docs/python/ --check
	$(PYTHON_VIRTUAL_BIN)/isort official/docs/python/ --check-only

## format-ruby - formats Ruby files
format-ruby:
	rubocop -A

## format-shell - formats shell files
format-shell:
	shfmt -i 2 -w official/docs/curl
	shfmt -i 2 -w official/guides/curl

.PHONY: help install install-csharp install-go install-java install-node install-php install-python install-ruby lint lint-csharp lint-go lint-java lint-node lint-php lint-python lint-ruby lint-shell format format-csharp format-go format-java format-node format-python format-python-check format-ruby format-shell
