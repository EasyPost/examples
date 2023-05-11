#!/usr/bin/env bash

# This script is used to adjust the Python client library style guides for use in the examples repo.

# Ref: sed to work on both Unix and MacOS: https://stackoverflow.com/a/44864004

# Replace extend-ignore = E203 with extend-ignore = E203, F821
sed -i.bak 's/extend-ignore = E203/extend-ignore = E203, F821/g' .flake8 && rm .flake8.bak
