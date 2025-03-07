import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_reports_create(report_type, report_date):
    easypost.Report.create(
        type=report_type,
        start_date=report_date,
        end_date=report_date,
    )

    build_response_snippet()


@pytest.mark.vcr()
def test_reports_retrieve(report_type, report_date):
    report = easypost.Report.create(
        type=report_type,
        start_date=report_date,
        end_date=report_date,
    )

    easypost.Report.retrieve(report.id)

    build_response_snippet()


@pytest.mark.vcr()
def test_reports_list(report_type, page_size):
    easypost.Report.all(type=report_type, page_size=page_size)

    build_response_snippet()
