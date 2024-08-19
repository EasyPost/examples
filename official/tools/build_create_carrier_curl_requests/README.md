# Build Create Carrier Curl Requests Tool

This tool creates a file containing all the create carrier account curl requests for all carriers on the EasyPost platform.

EasyPost publishes these curl requests for convenience in this repo along with populating those requests on each carrier guide on our documentation.

## Install

```shell
# Install virtual env
python3 -m venv venv

# Install EasyPost
venv/bin/pip install easypost
```

## Usage

```shell
EASYPOST_PROD_API_KEY=123... venv/bin/python build_curls.py
```
