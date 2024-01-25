import inspect
import os
import time

import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_pickups_create(test_client, shipment_one_call_buy, pickup_create):
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    pickup_create["shipment"] = shipment
    test_client.pickup.create(**pickup_create)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_pickups_retrieve(test_client, shipment_one_call_buy, pickup_create):
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    pickup_create["shipment"] = shipment
    pickup = test_client.pickup.create(**pickup_create)
    test_client.pickup.retrieve(id=pickup.id)

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_pickups_buy(test_client, shipment_one_call_buy, pickup_create, synchronous_sleep_seconds):
    function_name = inspect.stack()[0][3]
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    pickup_create["shipment"] = shipment
    pickup = test_client.pickup.create(**pickup_create)
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(synchronous_sleep_seconds)  # Wait enough time for the pickup to process before buying it
    test_client.pickup.buy(id=pickup.id, carrier="USPS", service="NextDay")

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_pickups_cancel(test_client, shipment_one_call_buy, pickup_create, synchronous_sleep_seconds):
    function_name = inspect.stack()[0][3]
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    pickup_create["shipment"] = shipment
    pickup = test_client.pickup.create(**pickup_create)
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(synchronous_sleep_seconds)  # Wait enough time for the pickup to process before buying it
    bought_pickup = test_client.pickup.buy(id=pickup.id, carrier="USPS", service="NextDay")
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(synchronous_sleep_seconds)  # Wait enough time for the pickup to process before cancelling it
    test_client.pickup.cancel(id=bought_pickup.id)

    build_response_snippet(interaction_index=3)


@pytest.mark.vcr()
def test_pickups_list(test_client, page_size):
    test_client.pickup.all(page_size=page_size)

    build_response_snippet()
