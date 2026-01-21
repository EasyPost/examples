# EasyPost API Examples

[![CI](https://github.com/EasyPost/examples/workflows/CI/badge.svg)](https://github.com/EasyPost/examples/actions?query=workflow%3ACI)

5,000+ code examples for using the EasyPost API across 7+ programming languages.

## Project Structure

- `community` code snippets contributed from the community. These may include custom workflows, how to integrate EasyPost with other software, etc. These are **unofficial and not supported or maintained by EasyPost**.
- `official` code snippets and examples that are used on EasyPost websites or provided for our user's benefit
  - `docs` code snippets that are shown on our [API docs](https://docs.easypost.com). Each language will have its own subdirectory. Within each language directory are versioned directories for that language's client library
  - `fixtures` mock data used as fixtures for our client library test suites, tooling, etc
  - `guides` code snippets that are used on our [guides page](https://docs.easypost.com/guides/getting-started). Each language will have its own subdirectory
  - `responses` responses for each supported endpoint of our API. These responses coincide with the example snippets found in the `docs` directory. Each will give you a good idea of what to expect back from the EasyPost API
- `style_guides` contain the style guides and configs for tooling we use in each public language we support
- `tools` contain utilities to help facilitate the code in this repo such as the response snippet generation suite

> NOTE: filenames may not match language convention - this is intentional. Our documentation website uses these example snippets and expects folder/filenames to follow a certain templated naming convention.

## Usage

Most of the examples found here should run out of the box without any alterations required with the exception of substituting your own EasyPost object IDs where applicable and EasyPost API key.

```bash
# Install all language environments
just install

# Install a specific language environment
just install-python
```

Once installed, run an example like you would any other script or tool for that language.

## Development

### Conventions

When creating new doc snippets, we follow a few conventions:

1. The example should be minimally viable - only include what is absolutely necessary to run the example. This ensures our example are simple, straightforward, and focused. An example is importing the lib, creating a client, calling the function with the data, printing the object to console.
2. With over 5,000 examples, it's paramount that our examples remain consistent. This is true across languages, versions (with the exception of syntax changes), and different functions. The examples have strong precedent, convention, and consistency - these should be maintained into the future.
3. When trying to determine what data to use for examples, it's probably best to use the same or similar data that our client library fixtures used during implementation. All of our client libraries use the same fixture data in tests ensuring consistency there, the same can (and should) be done for examples.
   1. You must use open source data (addresses, names, etc) - something that's not personally identifiable to a real person or business. Using EasyPost addresses or addresses of well-known public landmarks are good options
4. Examples must run "as-is" with no alterations (except for placeholder IDs and API keys). This ensures each of our examples can be quickly copy and pasted by users to try functionality quickly while they onboard, ensuring a great user experience.

### New Major Versions

When the client libraries have a new major version released, we need to create a new versioned directory in every language directory for this project. This ensures that users who do not upgrade client libraries still have a set of examples specific to their version to reference. When a new major version is released, copy the `current` directory and rename it to the previous major version. Then, make any necessary changes to the `current` directory docs (usually syntax changes if applicable). Rinse and repeat for every language directory.

### Importance of `current` Directory

Our docs (and marketing) websites submodule this `examples` repo so we can pull in stable example docs at various milestones. We use the `current` language directory to pull the doc snippets during the build process (the versioned directories are then retained for reference). As such, it's imperative that the `current` directory remains the most up-to-date set of docs and present in each langauge directory we have. We have tests in this project to ensure as much.
