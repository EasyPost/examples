# Response Generation Tooling

This tool regenerates the response snippets that accompany the example snippets on the EasyPost Docs page.

The tool is set up as a "test suite" that will record the requests and responses via `pyvcr` and load the YAML to extract the response content to save as a standalone file. Whenever new responses are needed, simply re-run the tool and each response will be regenerated.

NOTE: The test names are VERY important and must match up with the expected plural object and action name so that when generated, we can drop them into the website without manual intervention.

## Usage

You'll need to run the `make generate` command twice - it will fail the first time through. The first time will record the cassette, the second time it will save the standalone files. This is necessary because `vcrpy` doesn't save the file until the test function closes, though we call the standalone function inside the test function to capture the test name.

```bash
# Run the following to save recordings to standalone files
EASYPOST_TEST_API_KEY=putrealkeyhere EASYPOST_PROD_API_KEY=putrealkeyhere PARTNER_USER_PROD_API_KEY=putrealkeyhere REFERRAL_CUSTOMER_PROD_API_KEY=putrealkeyhere make generate

# Run the following to overwrite previous interactions
EASYPOST_TEST_API_KEY=putrealkeyhere EASYPOST_PROD_API_KEY=putrealkeyhere PARTNER_USER_PROD_API_KEY=putrealkeyhere REFERRAL_CUSTOMER_PROD_API_KEY=putrealkeyhere OVERWRITE=true make generate
```

**NOTE**: Some static data used by this tool, such as the USPS carrier account ID, is associated with the EasyPost Docs Tooling User. You must use that user's API keys to generate these snippets.

Generate response snippets are stored in the `responses` directory. Copy this entire directory to `official/docs/responses` once complete.

**NOTE**: The `responses` directory structure is exactly as expected by the docs website and other downstream projects -- do not alter it.
