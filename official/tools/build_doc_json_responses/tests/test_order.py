
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_orders_create(test_client, order_create):
    test_client.order.create(**order_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_orders_retrieve(test_client, order_create):
    order = test_client.order.create(**order_create)
    test_client.order.retrieve(id=order.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_orders_buy(test_client, order_create):
    order = test_client.order.create(**order_create)
    test_client.order.buy(
        id=order.id,
        carrier="USPS",
        service="First",
    )

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_orders_one_call_buy(test_client, order_create, usps_carrier_account_id):
    order_create["carrier"] = "USPS"
    order_create["service"] = "First"
    order_create["carrier_accounts"] = [usps_carrier_account_id]
    test_client.order.create(**order_create)

    build_response_snippet()
