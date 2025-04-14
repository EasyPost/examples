import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_shipping_refund_refund(test_client, shipment_one_call_buy):
    """Refunding a test shipment must happen within seconds of the shipment being created as test shipments naturally
    follow a flow of created -> delivered to cycle through tracking events in test mode - as such anything older
    than a few seconds in test mode may not be refundable.
    """
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    test_client.shipment.refund(id=shipment.id)

    build_response_snippet(interaction_index=1)
