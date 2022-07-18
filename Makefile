## help - Display help about make targets for this Makefile
help:
	@cat Makefile | grep '^## ' --color=never | cut -c4- | sed -e "`printf 's/ - /\t- /;'`" | column -s "`printf '\t'`" -t

## install - install all dependencies for each language
install: | install-ruby

## install-ruby - installs Ruby dependencies
install-ruby:
	bundle install

## lint - lints the entire project
lint: | lint-shell

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
format: | format-shell

## format-ruby - formats Ruby files
format-ruby:
	rubocop -A

## format-shell - formats shell files
format-shell:
	shfmt -i 2 -w official/docs/curl
	shfmt -i 2 -w official/guides/curl

.PHONY: help install install-ruby lint lint-ruby lint-shell format format-ruby format-shell
