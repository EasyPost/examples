import inspect
import os
import time

import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_batches_create(test_client, shipment_one_call_buy):
    test_client.batch.create(shipments=[shipment_one_call_buy])

    build_response_snippet()


@pytest.mark.vcr()
def test_batches_retrieve(test_client, shipment_one_call_buy):
    batch = test_client.batch.create(shipments=[shipment_one_call_buy])
    test_client.batch.retrieve(id=batch.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_batches_list(test_client, page_size):
    test_client.batch.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_batches_buy(test_client, shipment_one_call_buy, synchronous_sleep_seconds):
    function_name = inspect.stack()[0][3]
    batch = test_client.batch.create(shipments=[shipment_one_call_buy])
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(synchronous_sleep_seconds)  # Wait enough time for the batch to process buying the shipment
    test_client.batch.buy(id=batch.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_batches_scan_forms(test_client, shipment_one_call_buy, synchronous_sleep_seconds):
    function_name = inspect.stack()[0][3]
    batch = test_client.batch.create(shipments=[shipment_one_call_buy])
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(synchronous_sleep_seconds)  # Wait enough time for the batch to process buying the shipment
    test_client.batch.buy(id=batch.id)
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(synchronous_sleep_seconds)  # Wait enough time for the batch to process buying the shipment
    test_client.batch.create_scan_form(id=batch.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_batches_add_shipments(test_client, shipment_one_call_buy):
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    batch = test_client.batch.create()
    test_client.batch.add_shipments(id=batch.id, shipments=[shipment])

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_batches_remove_shipments(test_client, shipment_one_call_buy):
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    batch = test_client.batch.create()
    test_client.batch.add_shipments(id=batch.id, shipments=[shipment])
    test_client.batch.remove_shipments(id=batch.id, shipments=[shipment])

    build_response_snippet(interaction_index=3)


@pytest.mark.vcr()
def test_batches_label(test_client, shipment_one_call_buy, synchronous_sleep_seconds):
    function_name = inspect.stack()[0][3]
    batch = test_client.batch.create(shipments=[shipment_one_call_buy])
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(synchronous_sleep_seconds)  # Wait enough time for the batch to process buying the shipment
    test_client.batch.buy(id=batch.id)
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(synchronous_sleep_seconds)  # Wait enough time for the batch to process buying the shipment
    test_client.batch.label(id=batch.id, file_format="ZPL")

    build_response_snippet(interaction_index=2)
