import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_refunds_create(test_client, shipment_one_call_buy):
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    # We need to retrieve the shipment so that the tracking_code has time to populate
    retrieved_shipment = test_client.shipment.retrieve(id=shipment.id)
    test_client.refund.create(
        carrier="USPS",
        tracking_codes=retrieved_shipment.tracking_code,
    )

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_refunds_list(test_client, page_size):
    test_client.refund.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_refunds_retrieve(test_client, page_size):
    refunds = test_client.refund.all(page_size=page_size)
    test_client.refund.retrieve(id=refunds["refunds"][0]["id"])

    build_response_snippet(interaction_index=1)
