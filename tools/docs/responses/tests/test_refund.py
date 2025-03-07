import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_refunds_create(shipment_one_call_buy):
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    # We need to retrieve the shipment so that the tracking_code has time to populate
    retrieved_shipment = easypost.Shipment.retrieve(shipment.id)
    easypost.Refund.create(
        carrier="USPS",
        tracking_codes=retrieved_shipment.tracking_code,
    )

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_refunds_list(page_size):
    easypost.Refund.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_refunds_retrieve(page_size):
    refunds = easypost.Refund.all(page_size=page_size)
    easypost.Refund.retrieve(refunds["refunds"][0]["id"])

    build_response_snippet(interaction_index=1)
