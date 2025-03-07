import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_pickups_create(shipment_one_call_buy, pickup_create):
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    pickup_create["shipment"] = shipment
    easypost.Pickup.create(**pickup_create)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_pickups_retrieve(shipment_one_call_buy, pickup_create):
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    pickup_create["shipment"] = shipment
    pickup = easypost.Pickup.create(**pickup_create)
    easypost.Pickup.retrieve(pickup.id)

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_pickups_buy(shipment_one_call_buy, pickup_create):
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    pickup_create["shipment"] = shipment
    pickup = easypost.Pickup.create(**pickup_create)
    pickup.buy(carrier="USPS", service="NextDay")

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_pickups_cancel(shipment_one_call_buy, pickup_create):
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    pickup_create["shipment"] = shipment
    pickup = easypost.Pickup.create(**pickup_create)
    bought_pickup = pickup.buy(carrier="USPS", service="NextDay")
    bought_pickup.cancel()

    build_response_snippet(interaction_index=3)
