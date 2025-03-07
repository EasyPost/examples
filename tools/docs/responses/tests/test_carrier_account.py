import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_carrier_accounts_create(prod_api_key, carrier_account_create):
    carrier_account = easypost.CarrierAccount.create(**carrier_account_create)

    carrier_account.delete()  # Delete the carrier account once it's done being tested.

    build_response_snippet()


@pytest.mark.vcr()
def test_carrier_accounts_retrieve(prod_api_key, carrier_account_create):
    carrier_account = easypost.CarrierAccount.create(**carrier_account_create)
    easypost.CarrierAccount.retrieve(carrier_account.id)

    carrier_account.delete()  # Delete the carrier account once it's done being tested.

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_carrier_accounts_list(prod_api_key, page_size):
    easypost.CarrierAccount.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_carrier_accounts_update(prod_api_key, carrier_account_create):
    carrier_account = easypost.CarrierAccount.create(**carrier_account_create)
    carrier_account.description = "My custom description"
    carrier_account.save()

    carrier_account.delete()  # Delete the carrier account once it's done being tested.

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_carrier_accounts_delete(prod_api_key, carrier_account_create):
    carrier_account = easypost.CarrierAccount.create(**carrier_account_create)
    carrier_account.delete()

    build_response_snippet(interaction_index=1)
