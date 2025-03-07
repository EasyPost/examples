import inspect
import os
import time

import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_batches_create(shipment_one_call_buy):
    easypost.Batch.create(shipments=[shipment_one_call_buy])

    build_response_snippet()


@pytest.mark.vcr()
def test_batches_retrieve(shipment_one_call_buy):
    batch = easypost.Batch.create(shipments=[shipment_one_call_buy])
    easypost.Batch.retrieve(batch.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_batches_list(page_size):
    easypost.Batch.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_batches_create_and_buy(shipment_one_call_buy):
    """This may not be documented?"""
    easypost.Batch.create_and_buy(
        shipments=[
            shipment_one_call_buy,
            shipment_one_call_buy,
        ],
    )

    build_response_snippet()


@pytest.mark.vcr()
def test_batches_buy(shipment_one_call_buy):
    function_name = inspect.stack()[0][3]
    batch = easypost.Batch.create(shipments=[shipment_one_call_buy])
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(5)  # Wait enough time for the batch to process buying the shipment
    batch.buy()

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_batches_scan_forms(shipment_one_call_buy):
    function_name = inspect.stack()[0][3]
    batch = easypost.Batch.create(shipments=[shipment_one_call_buy])
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(5)  # Wait enough time for the batch to process buying the shipment
    batch.buy()
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(5)  # Wait enough time for the batch to process buying the shipment
    batch.create_scan_form()

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_batches_add_shipments(shipment_one_call_buy):
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    batch = easypost.Batch.create()
    batch.add_shipments(shipments=[shipment])

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_batches_remove_shipments(shipment_one_call_buy):
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    batch = easypost.Batch.create()
    batch.add_shipments(shipments=[shipment])
    batch.remove_shipments(shipments=[shipment])

    build_response_snippet(interaction_index=3)


@pytest.mark.vcr()
def test_batches_label(shipment_one_call_buy):
    function_name = inspect.stack()[0][3]
    batch = easypost.Batch.create(shipments=[shipment_one_call_buy])
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(5)  # Wait enough time for the batch to process buying the shipment
    batch.buy()
    if not os.path.exists(os.path.join("tests", "cassettes", f"{function_name}.yaml")):
        time.sleep(5)  # Wait enough time for the batch to process buying the shipment
    batch.label(file_format="ZPL")

    build_response_snippet(interaction_index=2)
