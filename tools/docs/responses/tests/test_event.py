import os
import easypost
import pytest
from builder.snippets import (
    build_response_snippet,
    save_raw_json,
)


@pytest.mark.vcr()
def test_events_list(page_size):
    easypost.Event.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_events_retrieve(page_size):
    events = easypost.Event.all(page_size=page_size)
    easypost.Event.retrieve(events["events"][0].id)

    build_response_snippet(interaction_index=1)


def test_events_retrieve_payload():
    response_dict = {
      "id": "payload_734d47163d0711ecb29421da38a2f124",
      "object": "Payload",
      "created_at": "2021-11-04T00:37:55Z",
      "updated_at": "2021-11-04T01:14:18Z",
      "request_url": "https://api.example.com/webhook",
      "request_headers": {
        "Accept": "application/json",
        "Content-Type": "application/json",
        "User-Agent": "Go-http-client/1.1"
      },
      "request_body": "{\"key\":\"value\"}",
      "response_code": 200,
      "response_headers": {
        "Content-Type": "application/json; charset=utf-8",
        "Date": "Tue, 02 Nov 2021 23:37:55 GMT",
        "Server": "nginx/1.19.6",
        "X-Content-Type-Options": "nosniff",
        "X-Frame-Options": "SAMEORIGIN",
        "X-Request-Id": "a1b2c3d4e5f6g7h8i9j0",
        "X-Runtime": "0.001000",
        "X-Xss-Protection": "1; mode=block"
      },
      "total_time": 34
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)


def test_events_retrieve_all_payloads():
    response_dict = {
        "payloads": [
            {
            "id": "payload_734d47163d0711ecb29421da38a2f124",
            "object": "Payload",
            "created_at": "2021-11-04T00:37:55Z",
            "updated_at": "2021-11-04T01:14:18Z",
            "request_url": "https://api.example.com/webhook",
            "request_headers": {
                "Accept": "application/json",
                "Content-Type": "application/json",
                "User-Agent": "Go-http-client/1.1"
            },
            "request_body": "{\"key\":\"value\"}",
            "response_code": 200,
            "response_headers": {
                "Content-Type": "application/json; charset=utf-8",
                "Date": "Tue, 02 Nov 2021 23:37:55 GMT",
                "Server": "nginx/1.19.6",
                "X-Content-Type-Options": "nosniff",
                "X-Frame-Options": "SAMEORIGIN",
                "X-Request-Id": "a1b2c3d4e5f6g7h8i9j0",
                "X-Runtime": "0.001000",
                "X-Xss-Protection": "1; mode=block"
            },
            "total_time": 34
            },
            {
            "id": "payload_734d47163d0711ecb29421da38a2f414",
            "object": "Payload",
            "created_at": "2021-11-04T00:37:55Z",
            "updated_at": "2021-11-04T01:14:18Z",
            "request_url": "https://api.example.com/webhook",
            "request_headers": {
                "Accept": "application/json",
                "Content-Type": "application/json",
                "User-Agent": "Go-http-client/1.1"
            },
            "request_body": "{\"key\":\"value\"}",
            "response_code": 404,
            "response_headers": {
                "Content-Type": "application/json; charset=utf-8",
                "Date": "Tue, 02 Nov 2021 23:37:55 GMT",
                "Server": "nginx/1.19.6",
                "X-Content-Type-Options": "nosniff",
                "X-Frame-Options": "SAMEORIGIN",
                "X-Request-Id": "a1b2c3d4e5f6g7h8i9j0",
                "X-Runtime": "0.001000",
                "X-Xss-Protection": "1; mode=block"
            },
            "total_time": 122
            }
        ]
    }
    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)
