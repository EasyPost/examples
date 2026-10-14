import os

import pytest
from builder.snippets import (
    build_response_snippet,
    save_raw_json,
)


@pytest.mark.vcr()
def test_reports_create(test_client, report_type, report_date):
    test_client.report.create(
        type=report_type,
        start_date=report_date,
        end_date=report_date,
    )

    build_response_snippet()


@pytest.mark.vcr()
def test_reports_retrieve(test_client, report_type, report_date):
    report = test_client.report.create(
        type=report_type,
        start_date=report_date,
        end_date=report_date,
    )

    test_client.report.retrieve(id=report.id)

    build_response_snippet()


@pytest.mark.vcr()
def test_reports_list(test_client, report_type, page_size):
    # TODO: For whatever reason, the response for reports list returns empty for this account in test mode, hardcoded
    response_dict = {
        "reports": [
            {
                "id": "shprep_82ee56b0b96247528187f3f9b4fa1360",
                "object": "ShipmentReport",
                "created_at": "2024-01-24T00:07:24Z",
                "updated_at": "2024-01-24T00:07:24Z",
                "start_date": "2022-10-01",
                "end_date": "2022-10-01",
                "mode": "test",
                "status": "empty",
                "url": None,
                "url_expires_at": None,
                "include_children": False,
            }
        ],
        "has_more": True,
    }

    test_name = os.environ.get("PYTEST_CURRENT_TEST").split(":")[-1].split(" ")[0]
    save_raw_json(test_name, response_dict)
