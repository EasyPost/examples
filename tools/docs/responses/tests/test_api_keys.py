import os

import easypost
import pytest
from builder.snippets import (
    build_response_snippet,
    save_raw_json,
)


@pytest.mark.vcr()
def test_api_keys_retrieve(prod_api_key):
    user = easypost.User.retrieve_me()
    user.api_keys()

    build_response_snippet(interaction_index=1)


def test_api_keys_create():
    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]

    response_dict = {
        "object": "ApiKey",
        "key": "<REDACTED>",
        "mode": "test",
        "created_at": "2022-01-29T00:02:36Z",
        "active": True,
        "id": "ak_...",
    }

    save_raw_json(test_name, response_dict)


def test_api_keys_delete():
    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]

    response_dict = {}

    save_raw_json(test_name, response_dict)


def test_api_keys_enable():
    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]

    response_dict = {
        "object": "ApiKey",
        "key": "<REDACTED>",
        "mode": "test",
        "created_at": "2022-01-29T00:02:36Z",
        "active": True,
        "id": "ak_...",
    }

    save_raw_json(test_name, response_dict)


def test_api_keys_disable():
    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]

    response_dict = {
        "object": "ApiKey",
        "key": "<REDACTED>",
        "mode": "test",
        "created_at": "2022-01-29T00:02:36Z",
        "active": False,
        "id": "ak_...",
    }

    save_raw_json(test_name, response_dict)
