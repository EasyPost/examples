import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_shipments_create(test_client, shipment_create):
    test_client.shipment.create(**shipment_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_shipments_retrieve(test_client, shipment_create):
    shipment = test_client.shipment.create(**shipment_create)
    test_client.shipment.retrieve(id=shipment.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_shipments_list(test_client, page_size):
    test_client.shipment.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_shipments_buy(test_client, shipment_create):
    shipment = test_client.shipment.create(**shipment_create)
    test_client.shipment.buy(id=shipment.id, rate=shipment.lowest_rate(), insurance="249.99")

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_shipments_one_call_buy(test_client, shipment_one_call_buy):
    test_client.shipment.create(**shipment_one_call_buy)

    build_response_snippet()


@pytest.mark.vcr()
def test_shipments_label(test_client, shipment_create):
    shipment = test_client.shipment.create(**shipment_create)
    test_client.shipment.buy(id=shipment.id, rate=shipment.lowest_rate())
    test_client.shipment.label(id=shipment.id, file_format="ZPL")

    build_response_snippet(interaction_index=2)
