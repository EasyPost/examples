# EasyPost API Examples

[![CI](https://github.com/EasyPost/examples/workflows/CI/badge.svg)](https://github.com/EasyPost/examples/actions?query=workflow%3ACI)

Thousands of code examples for using the EasyPost API across 7+ programming languages.

## Folder Structure

- `community` code snippets contributed from the community. These may include custom workflows, how to integrate EasyPost with other software, etc. These are **unofficial** and **not supported or maintained by EasyPost**.
- `official` official code snippets that populate on the EasyPost website
  - `docs` code snippets that populate on our API docs page. Each language will have its own subdirectory
  - `fixtures` test data used as fixtures in our client library test suites
  - `guides` code snippets that populate on our guides page. Each language will have its own subdirectory
  - `responses` responses for our example snippets found in the `docs` directory that will give you a good idea of what to expect back from the EasyPost API
- `style_guides` contain the style guides and configs for tooling we use in each public language we support
- `tools` contain utilities to help facilitate the code in this repo such as the response snippet generation suite

> NOTE: filenames may not match language convention - this is intentional. Our documentation website uses these example snippets and expects folder/filenames to follow a certain templated naming convention.

## Usage

Most of the examples found here should run out of the box without any alterations required with the exception of substituting your own EasyPost object IDs where applicable.

```bash
# Install all language environments
make install

# Install a specific language environment
make install-python
```

Once installed, run an example like you would any other script or tool for that language.
