## help - Display help about make targets for this Makefile
help:
	@cat Makefile | grep '^## ' --color=never | cut -c4- | sed -e "`printf 's/ - /\t- /;'`" | column -s "`printf '\t'`" -t

## install - install all dependencies for each language
install: | install-csharp install-ruby

## install-csharp - install C# dependencies
install-csharp:
	dotnet tool install -g dotnet-format

## install-ruby - installs Ruby dependencies
install-ruby:
	bundle install

## lint - lints the entire project
lint: | lint-csharp lint-ruby lint-shell

## lint-csharp - lint C# files
lint-csharp:
	dotnet-format --check --include official/docs/csharp/ --exclude /
	dotnet-format --check --include official/guides/csharp/ --exclude /

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
format: | format-csharp format-ruby format-shell

## format-csharp - formats C# files
format-csharp:
	dotnet format --include official/docs/csharp/ --exclude /
	dotnet format --include official/guides/csharp/ --exclude /

## format-ruby - formats Ruby files
format-ruby:
	rubocop -A

## format-shell - formats shell files
format-shell:
	shfmt -i 2 -w official/docs/curl
	shfmt -i 2 -w official/guides/curl

.PHONY: help install install-csharp install-ruby lint lint-csharp lint-ruby lint-shell format format-csharp format-ruby format-shell