# Build Create Carrier Curl Requests Tool

This tool generates all carrier create curl files from the `/carrier_types` endpoint.

EasyPost publishes these curl requests for convenience in this repo and uses them to populate each carrier guide in our docs.

The output is intentionally fully automated. Whatever carrier types are available from `/carrier_types` at run time is the source of truth for what should be checked in.

## Carrier Availability Feature Flags

Some carriers are behind feature flags and will not be returned by `/carrier_types` unless the API user has the associated `available_for_presentation` flag enabled for that carrier.

It is recommended to run this tool with the `Docs Tooling` EasyPost user, since that user is already configured with the needed carrier feature flags and should return the full list.

If the Docs Tooling user is not available, the user running this tool must be enabled on the backend for all `available_for_presentation` feature flags.

The tool also includes static fallbacks for carriers under `STATIC_CARRIER_TYPES`, which are currently known to be omitted from `/carrier_types` due to not being marked for presentation.

## Install

```shell
# Install virtual env
python3 -m venv venv

# Install EasyPost
venv/bin/pip install easypost
```

## Usage

The script automatically deletes and rebuilds `official/guides/create-carrier-curls` on every run.

```shell
EASYPOST_PROD_API_KEY=123... venv/bin/python build_curls.py
```

This workflow is required because it guarantees all of the following:

- New carrier create curls are added automatically.
- Existing carrier create curls are refreshed with any updated values.
- Carrier create curls for carriers that are no longer available are removed automatically.

Do not add one-off manual curl files to `official/guides/create-carrier-curls`. If a carrier is genuinely addable via API but does not appear in this tool output (for example, because it is currently marked unavailable on the EasyPost backend), we still do not check in manual exceptions. The next automated run will remove manual files anyway, and the intended process is fully automated.
