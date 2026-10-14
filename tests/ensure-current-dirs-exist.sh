#!/bin/bash

# This script ensures that each of our languages `docs` directories has a `current` directory to ensure snippets populate on our website

LINT_FAILED=0
FAILED_LANG=""

main() {
  # Iterate over each directory and run tests
  for LANG_FULL_PATH in official/docs/*; do
    if [ -d "$LANG_FULL_PATH" ]; then
      if [ "$LANG_FULL_PATH" == "official/docs/responses" ]; then
        # The responses dir won't have a `current` set since these aren't versioned
        continue
      elif [ ! -d "$LANG_FULL_PATH"/current ]; then
        FAILED_LANG+="$LANG_FULL_PATH\n"
        LINT_FAILED=1
      fi
    fi
  done

  # Set exit code based on if the tests passed or failed
  if [ "$LINT_FAILED" == 0 ]; then
    printf "Check for 'current' directories in docs passed!\n"
    exit 0
  else
    printf "The following language directories do not have a 'current' directory:\n"
    printf "%b" "$FAILED_LANG"
    exit 1
  fi
}

main
