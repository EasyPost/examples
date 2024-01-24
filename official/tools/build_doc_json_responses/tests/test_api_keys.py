import os

import pytest
from builder.snippets import (
    build_response_snippet,
    save_raw_json,
)


@pytest.mark.vcr()
def test_api_keys_retrieve(prod_client):
    user = prod_client.user.retrieve_me()
    prod_client.api_keys.retrieve_api_keys_for_user(id=user.id)

    build_response_snippet(interaction_index=1)


def test_api_keys_create(prod_client):
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


def test_api_keys_delete(prod_client):
    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]

    response_dict = {}

    save_raw_json(test_name, response_dict)


def test_api_keys_enable(prod_client):
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


def test_api_keys_disable(prod_client):
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
