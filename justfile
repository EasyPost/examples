PYTHON_BINARY := "python3"
PYTHON_VIRTUAL_ENV := "venv"
PYTHON_VIRTUAL_BIN := PYTHON_VIRTUAL_ENV / "bin"

# Cleans the entire project by removing the virtual environment and clearing out .pyc files along with node_modules and vendor folders
clean: clean-go clean-java clean-node clean-php clean-python

# Cleans the Go environment
clean-go:
	rm -rf vendor

# Cleans the Java environment
clean-java:
	rm -rf target
	find . -name '*.jar' -delete

# Cleans the Python environment
clean-python:
	rm -rf venv dist *.egg-info .coverage
	find . -name '*.pyc' -delete

# Cleans the Node environment
clean-node:
	rm -rf node_modules

# Cleans the PHP environment
clean-php:
	rm -rf vendor bin

# Installs all dependencies for each language
install: install-csharp install-go install-java install-node install-php install-python install-ruby

# Installs C# dependencies
install-csharp:
	sh ./symlink_directory_files.sh style_guides/csharp .
	dotnet tool install -g dotnet-format || exit 0

# Installs Go dependencies
install-go:
	sh ./symlink_directory_files.sh style_guides/golang .
	curl -sSfL https://raw.githubusercontent.com/golangci/golangci-lint/master/install.sh | sh -s -- -b "$(go env GOPATH)/bin" v1.60.3
	go mod vendor

# Installs Java dependencies
install-java:
	sh ./symlink_directory_files.sh style_guides/java .
	curl -LJs https://github.com/checkstyle/checkstyle/releases/download/checkstyle-10.3.1/checkstyle-10.3.1-all.jar -o checkstyle.jar
	mvn dependency:resolve

# Installs Node dependencies
install-node:
	sh ./symlink_directory_files.sh style_guides/node .
	npm install

# Installs PHP dependencies
install-php:
	sh ./symlink_directory_files.sh style_guides/php .
	composer install

# Installs Python dependencies
install-python:
	sh ./symlink_directory_files.sh style_guides/python .
	{{PYTHON_BINARY}} -m venv venv
	{{PYTHON_VIRTUAL_BIN}}/pip install -e ."[dev]"

# Installs Ruby dependencies
install-ruby:
	sh ./symlink_directory_files.sh style_guides/ruby .
	bundle install

# Lints the entire project
lint: lint-csharp lint-go lint-java lint-node lint-php lint-python lint-ruby lint-shell

# Lints C# files
lint-csharp:
	dotnet format whitespace --include official/docs/csharp/ --folder --verify-no-changes
	dotnet format whitespace --include official/guides/ --folder --verify-no-changes

# Lints Go files
lint-go:
	"$(go env GOPATH)/bin/golangci-lint" run official/docs/golang/current/... community/... official/guides/...

# Lints Java files
lint-java:
	java -jar checkstyle.jar src -c easypost_java_style.xml -d official/docs/java/*
	java -jar checkstyle.jar src -c easypost_java_style.xml -d official/guides/*

# Lints Node files
lint-node:
	npm run lint

# Lints PHP files
lint-php:
	composer lint

# Lints Python files
lint-python:
	{{PYTHON_VIRTUAL_BIN}}/flake8 official/docs/python/
	{{PYTHON_VIRTUAL_BIN}}/flake8 official/guides/
	{{PYTHON_VIRTUAL_BIN}}/flake8 official/landing_pages/

# Lints Ruby files
lint-ruby:
	bundle exec rubocop

# Lints shell files
lint-shell:
	shellcheck official/docs/curl/current/**/*.sh -e SC2148,SC2034
	shfmt -i 2 -d official/docs/curl
	shellcheck official/guides/**/curl/*.sh -e SC2148,SC2034
	shfmt -i 2 -d official/guides/**/curl

# Formats the entire project
format: format-csharp format-go format-java format-node format-php format-python format-ruby format-shell

# Formats C# files
format-csharp:
	dotnet format whitespace --include official/docs/csharp/ --folder
	dotnet format whitespace --include official/guides/ --folder

# Formats Go files
format-go:
	"$(go env GOPATH)/bin/golangci-lint" run --fix

# Formats Java files
format-java:
	echo "Not implemented"

# Formats Node files
format-node:
	npm run format

# Formats PHP files
format-php:
	composer fix

# Formats Python files
format-python:
	{{PYTHON_VIRTUAL_BIN}}/black official/docs/python/
	{{PYTHON_VIRTUAL_BIN}}/isort official/docs/python/ --lines-after-imports -1 --no-sections
	{{PYTHON_VIRTUAL_BIN}}/black official/guides/
	{{PYTHON_VIRTUAL_BIN}}/isort official/guides/ --lines-after-imports -1 --no-sections
	{{PYTHON_VIRTUAL_BIN}}/black official/landing_pages/
	{{PYTHON_VIRTUAL_BIN}}/isort official/landing_pages/ --lines-after-imports -1 --no-sections

# Formats Ruby files
format-ruby:
	bundle exec rubocop -a

# Formats shell files
format-shell:
	shfmt -i 2 -w official/docs/curl/*
	shfmt -i 2 -w official/guides/**/curl/*

# Checks that Node files conform to the correct format
format-node-check:
	npm run check

# Checks that Python files conform to the correct format
format-python-check:
	{{PYTHON_VIRTUAL_BIN}}/black official/docs/python/ --check
	{{PYTHON_VIRTUAL_BIN}}/isort official/docs/python/ --lines-after-imports -1 --no-sections --check-only
	{{PYTHON_VIRTUAL_BIN}}/black official/guides/ --check
	{{PYTHON_VIRTUAL_BIN}}/isort official/guides/ --lines-after-imports -1 --no-sections --check-only
	{{PYTHON_VIRTUAL_BIN}}/black official/landing_pages/ --check
	{{PYTHON_VIRTUAL_BIN}}/isort official/landing_pages/ --lines-after-imports -1 --no-sections --check-only
