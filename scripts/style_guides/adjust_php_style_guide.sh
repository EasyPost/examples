#!/usr/bin/env bash

# This script is used to adjust the PHP client library style guides for use in the examples repo.

# Ref: sed to work on both Unix and MacOS: https://stackoverflow.com/a/44864004

# Replace <file>lib</file> with <file>official/docs/php</file>
sed -i.bak 's/<file>lib<\/file>/<file>official\/docs\/php<\/file>/g' phpcs.xml && rm phpcs.xml.bak
# Delete <file>test</file> tag
sed -i.bak '/<file>test<\/file>/d' phpcs.xml && rm phpcs.xml.bak
