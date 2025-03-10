import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_scan_form_create(shipment_one_call_buy):
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    easypost.ScanForm.create(shipment=[shipment])

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_scan_form_retrieve(shipment_one_call_buy):
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    scanform = easypost.ScanForm.create(shipment=[shipment])
    easypost.ScanForm.retrieve(scanform.id)

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_scan_form_list(page_size):
    easypost.ScanForm.all(page_size=page_size)

    build_response_snippet()
