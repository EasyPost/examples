
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_scan_form_create(test_client, shipment_one_call_buy):
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    test_client.scan_form.create(shipment=[shipment])

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_scan_form_retrieve(test_client, shipment_one_call_buy):
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    scanform = test_client.scan_form.create(shipment=[shipment])
    test_client.scan_form.retrieve(id=scanform.id)

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_scan_form_list(test_client, page_size):
    test_client.scan_form.all(page_size=page_size)

    build_response_snippet()
