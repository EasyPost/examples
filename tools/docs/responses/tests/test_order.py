import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_orders_create(order_create):
    """NOTE: The response will show USPS because our test user doesn't have a FedEx account setup which is what
    the example snippets use because FedEx supports Orders and USPS doesn't.
    """
    easypost.Order.create(**order_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_orders_retrieve(order_create):
    order = easypost.Order.create(**order_create)
    easypost.Order.retrieve(order.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_orders_buy(order_create):
    """NOTE: The response will show USPS because our test user doesn't have a FedEx account setup which is what
    the example snippets use because FedEx supports Orders and USPS doesn't.
    """
    order = easypost.Order.create(**order_create)
    order.buy(
        carrier="USPS",
        service="First",
    )

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_orders_one_call_buy(order_create, usps_carrier_account_id):
    """NOTE: The response will show USPS because our test user doesn't have a FedEx account setup which is what
    the example snippets use because FedEx supports Orders and USPS doesn't.
    """
    order_create["carrier"] = "USPS"
    order_create["service"] = "First"
    order_create["carrier_accounts"] = [usps_carrier_account_id]
    easypost.Order.create(**order_create)

    build_response_snippet()
