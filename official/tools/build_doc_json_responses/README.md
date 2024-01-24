# Response Generation Tooling

This tool regenerates the response snippets that accompany the example snippets on the EasyPost Docs page.

The tool is set up as a "test suite" that will record the requests and responses via `pyvcr` and load the YAML to extract the response content to save as a standalone file. Whenever new responses are needed, simply re-run the tool and each response will be regenerated.

NOTE: The test names are VERY important and must match up with the expected plural object and action name so that when generated, we can drop them into the website without manual intervention.

## Installation

```bash
make install
```

## Usage

First, if you are regenerating response snippets, you will first need to delete the related cassette file(s) in `tests/cassettes`. If a cassette file already exists for a given snippet, it will not be overwritten and the generated response snippet will not be updated.

Next, you will need to run the `make generate` command twice - it will fail the first time through. The first time will record the cassette, the second time it will save the snippet files. This is necessary because `vcrpy` doesn't save a cassette until the test function closes, though we call the standalone function inside the test function to capture the test name.

```bash
# Run the following to save HTTP recordings
EASYPOST_TEST_API_KEY=putrealkeyhere EASYPOST_PROD_API_KEY=putrealkeyhere PARTNER_USER_PROD_API_KEY=putrealkeyhere REFERRAL_CUSTOMER_PROD_API_KEY=putrealkeyhere make generate

# Run the same command again to save the response snippets
EASYPOST_TEST_API_KEY=putrealkeyhere EASYPOST_PROD_API_KEY=putrealkeyhere PARTNER_USER_PROD_API_KEY=putrealkeyhere REFERRAL_CUSTOMER_PROD_API_KEY=putrealkeyhere make generate
```

**NOTE**: Some static data used by this tool, such as the USPS carrier account ID, is associated with the EasyPost Docs Tooling User. You must use that user's API keys to generate these snippets.

Generate response snippets are stored in the `responses` directory. Copy this entire directory to `official/docs/responses` once complete.

**NOTE**: The `responses` directory structure is exactly as expected by the docs website and other downstream projects -- do not alter it.

## Troubleshooting

### A bunch of "F"s

This is expected. Tests will fail the first time through because the final step of each test is to generate a response snippet from the just-recorded cassette. Unfortunately, `pyvcr` does not save the cassette files until after the unit test is completed, meaning the file does not exist when the response snippet generator is looking for it.

If you run the test a second time, the cassette files will exist, allowing the response snippet generator to read it, allowing the tests to pass.
