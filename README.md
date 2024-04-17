# EasyPost API Examples

[![CI](https://github.com/EasyPost/examples/workflows/CI/badge.svg)](https://github.com/EasyPost/examples/actions?query=workflow%3ACI)

This repository holds hundreds of code examples for using the EasyPost API across 7+ programming languages.

## Folder Structure

- `official` holds all the official code snippets that populate on the EasyPost website
  - `docs` holds all the code snippets that populate on our API docs page. Each language will have its own subdirectory
  - `fixtures` holds all of the test data used as fixtures in our client library test suites
  - `guides` holds all the code snippets that populate on our guides page. Each language will have its own subdirectory
  - `responses` holds all of the associated responses for our example snippets found in the `docs` directory that will give you a good idea of what to expect back from the EasyPost API
- `community` holds code snippets contributed from the community. These may include custom workflows, how to integrate EasyPost with other software, etc. These are **unofficial** and **not supported or maintained by EasyPost**.

## Usage

Most of the examples found here should run out of the box without any alterations required with the exception of substituting your own EasyPost object IDs where applicable.

```bash
# Install all language environments
make install

# Install a specific language environment
make install-python
```

Once installed, run an example like you would any other script or tool for that language.

NOTE: filenames may not match language convention - this is intentional. Our website also uses these example snippets and expects folder/filenames to follow a certain templated naming convention.
