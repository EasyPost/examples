import pytest
from builder.snippets import build_response_snippet


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
    test_client.report.all(type=report_type, page_size=page_size)

    build_response_snippet()
