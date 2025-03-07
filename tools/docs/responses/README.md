# Response Generation Tooling

This tool generates the response snippets that accompany the example snippets on the EasyPost Docs page.

The tool is setup as a "test suite" that will record the requests and responses via `pyvcr` and load the yaml to extract the response content to save as a standalone file. Whenever new responses are needed, simply re-run the tool and each response will be regenerated.

> NOTE: The test names are VERY important and must match up with the expected plural object and action name so that when generated, we can drop them into the examples without manual intervention.

## Usage

> NOTE: Currently, you'll need to run the command twice - it will fail the first time through. The first time will record the cassette, the second time it will save the standalone files. This is necessary because `vcrpy` doesn't save the file until the test function closes, though we call the standalone function inside the test function to capture the test name.

```bash
# Run the following to save recordings to standalone files
make test

# Run the following to overwrite previous interactions
OVERWRITE=true make test
```
