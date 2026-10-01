import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_carrier_accounts_create(prod_client, carrier_account_create):
    carrier_account = prod_client.carrier_account.create(**carrier_account_create)

    try:
        build_response_snippet()
    finally:
        # we are deleting the carrier account here so we don't keep sending events to a dead carrier account.
        prod_client.carrier_account.delete(id=carrier_account.id)


@pytest.mark.vcr()
def test_carrier_accounts_retrieve(prod_client, carrier_account_create):
    carrier_account = prod_client.carrier_account.create(**carrier_account_create)

    try:
        prod_client.carrier_account.retrieve(id=carrier_account.id)
        build_response_snippet(interaction_index=1)
    finally:
        # we are deleting the carrier account here so we don't keep sending events to a dead carrier account.
        prod_client.carrier_account.delete(id=carrier_account.id)


@pytest.mark.vcr()
def test_carrier_accounts_list(prod_client, page_size):
    prod_client.carrier_account.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_carrier_accounts_update(prod_client, carrier_account_create):
    carrier_account = prod_client.carrier_account.create(**carrier_account_create)

    try:
        carrier_account = prod_client.carrier_account.update(id=carrier_account.id, description="My custom description")
        build_response_snippet(interaction_index=1)
    finally:
        # we are deleting the carrier account here so we don't keep sending events to a dead carrier account.
        prod_client.carrier_account.delete(id=carrier_account.id)


@pytest.mark.vcr()
def test_carrier_accounts_delete(prod_client, carrier_account_create):
    carrier_account = prod_client.carrier_account.create(**carrier_account_create)

    prod_client.carrier_account.delete(id=carrier_account.id)

    build_response_snippet(interaction_index=1)
