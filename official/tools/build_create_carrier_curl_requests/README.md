# Build Create Carrier Curl Requests Tool

This tool creates a file containing all the create carrier account curl requests for all carriers on the EasyPost platform.

EasyPost publishes these curl requests for convenience in this repo along with populating those requests on each carrier guide on our documentation.

## Install

1. Install a virtual env
2. Install `easypost` via pip
3. Setup `.env` file as needed or pass env vars to the script on the CLI

## Usage

```shell
EASYPOST_PROD_API_KEY=123... venv/bin/python build_curls.py > carrier_curl_requests.sh
```
