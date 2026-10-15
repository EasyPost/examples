import os

from builder.snippets import save_raw_json


def test_embeddables_session():
    response_dict = {
        "object": "EmbeddablesSession",
        "session_id": "esess_123",
        "created_at": "2026-10-06T17:30:30Z",
        "expires_at": "2026-10-06T17:35:30Z",
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)
