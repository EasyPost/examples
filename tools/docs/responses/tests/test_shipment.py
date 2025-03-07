import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_shipments_create(shipment_create):
    easypost.Shipment.create(**shipment_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_shipments_retrieve(shipment_create):
    shipment = easypost.Shipment.create(**shipment_create)
    easypost.Shipment.retrieve(shipment.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_shipments_list(page_size):
    easypost.Shipment.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_shipments_buy(shipment_create):
    shipment = easypost.Shipment.create(**shipment_create)
    shipment.buy(rate=shipment.lowest_rate(), insurance="249.99")

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_shipments_one_call_buy(shipment_one_call_buy):
    easypost.Shipment.create(**shipment_one_call_buy)

    build_response_snippet()


@pytest.mark.vcr()
def test_shipments_label(shipment_create):
    shipment = easypost.Shipment.create(**shipment_create)
    shipment.buy(rate=shipment.lowest_rate())
    shipment.label(file_format="ZPL")

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_shipments_refund(shipment_one_call_buy):
    """Refunding a test shipment must happen within seconds of the shipment being created as test shipments naturally
    follow a flow of created -> delivered to cycle through tracking events in test mode - as such anything older
    than a few seconds in test mode may not be refundable.
    """
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    shipment.refund()

    build_response_snippet(interaction_index=1)
