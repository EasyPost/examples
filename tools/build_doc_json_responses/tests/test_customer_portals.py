import os

from builder.snippets import save_raw_json


def test_customer_portals_create():
    response_dict = {
        "object": "CustomerPortalAccountLink",
        "created_at": "2026-10-06T17:30:30Z",
        "expires_at": "2026-10-06T17:35:30Z",
        "link": "https://app.easypost.com/customer-portal/onboarding?session_id={SESSION_ID}",
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)
