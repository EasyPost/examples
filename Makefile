## help - Display help about make targets for this Makefile
help:
	@cat Makefile | grep '^## ' --color=never | cut -c4- | sed -e "`printf 's/ - /\t- /;'`" | column -s "`printf '\t'`" -t

## install - install all dependencies for each language
install: | install-csharp install-java install-ruby

## install-csharp - install C# dependencies
install-csharp:
	dotnet tool install -g dotnet-format

## install-java - installs Java dependencies
install-java:
    # install CheckStyle jar for running locally
	wget -O checkstyle.jar -q https://github.com/checkstyle/checkstyle/releases/download/checkstyle-10.3.1/checkstyle-10.3.1-all.jar
    # download EasyPost stylesheet, use local style suppressions
	wget -O easypost_java_style.xml -q https://raw.githubusercontent.com/EasyPost/easypost-java/master/easypost_java_style.xml

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


## lint-java - lints Java files
lint-java:
	java -jar checkstyle.jar src -c easypost_java_style.xml -d official/docs/java/
	java -jar checkstyle.jar src -c easypost_java_style.xml -d official/guides/java/

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
format: | format-csharp format-java format-shell

## format-csharp - formats C# files
format-csharp:
    # clean up whitespace formatting
    # folder options skip looking for a project/solution, just analyze any *.cs file
	dotnet format whitespace --include official/docs/csharp/ --folder
	dotnet format whitespace --include official/guides/csharp/ --folder


## format-java - formats Java files
format-java:
	echo "Not implemented"

## format-ruby - formats Ruby files
format-ruby:
	rubocop -A

## format-shell - formats shell files
format-shell:
	shfmt -i 2 -w official/docs/curl
	shfmt -i 2 -w official/guides/curl

.PHONY: help install install-java install-ruby lint lint-java lint-ruby lint-shell format format-java format-ruby format-shell
