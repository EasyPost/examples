PYTHON_BINARY := python3
VIRTUAL_ENV := venv
VIRTUAL_BIN := $(VIRTUAL_ENV)/bin
SOURCE_CODE_DIR := builder
RESPONSES_DIR := responses
TEST_DIR := tests

## help - Display help about make targets for this Makefile
help:
	@cat Makefile | grep '^## ' --color=never | cut -c4- | sed -e "`printf 's/ - /\t- /;'`" | column -s "`printf '\t'`" -t

## build - Build the Python package needed to run the project
build:
	$(VIRTUAL_BIN)/python setup.py sdist bdist_wheel

## clean - Remove the virtual environment and clear out .pyc files
clean:
	rm -rf $(VIRTUAL_ENV) dist/ build/ *.egg-info/ .pytest_cache .mypy_cache
	find . -name '*.pyc' -delete

## black - Runs the Black Python formatter against the project
black:
	$(VIRTUAL_BIN)/black $(SOURCE_CODE_DIR)/ $(TEST_DIR)/

## black-check - Checks if the project is formatted correctly against the Black rules
black-check:
	$(VIRTUAL_BIN)/black $(SOURCE_CODE_DIR)/ $(TEST_DIR)/ --check

## flake8 - Runs the Flake8 linter against the project
flake8:
	$(VIRTUAL_BIN)/flake8 $(SOURCE_CODE_DIR)/ $(TEST_DIR)/

## generate - Generate the JSON response bodies
generate:
	$(VIRTUAL_BIN)/pytest

## install - Install the project locally
install:
	$(PYTHON_BINARY) -m venv $(VIRTUAL_ENV)
	$(VIRTUAL_BIN)/pip install -e ."[dev]"
	git submodule init
	git submodule update

## isort - Sorts imports throughout the project
isort:
	$(VIRTUAL_BIN)/isort $(SOURCE_CODE_DIR)/ $(TEST_DIR)/

## isort-check - Checks that imports throughout the project are sorted correctly
isort-check:
	$(VIRTUAL_BIN)/isort $(SOURCE_CODE_DIR)/ $(TEST_DIR)/ --check-only

## lint - Runs all linting and formatting tools against the project
lint: black-check isort-check flake8

## lint-fix - Automatically fixes linting and formatting issues
lint-fix: black isort

.PHONY: help build clean black black-check flake8 generate install isort isort-check lint lint-fix
