import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_addresses_create(address_create):
    easypost.Address.create(**address_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_create_and_verify(address_create_and_verify):
    easypost.Address.create_and_verify(**address_create_and_verify)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_verify_param(address_create):
    address_create["verify"] = True
    easypost.Address.create(**address_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_verify_strict_param(address_create):
    address_create["verify_strict"] = True
    easypost.Address.create(**address_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_verify(address_create):
    """Verify and already created address."""
    address = easypost.Address.create(**address_create)
    address.verify()

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_addresses_verify_failure(address_create):
    """Verify and already created address."""
    address_create["street1"] = "UNDELIVERABLE ST"
    address_create["street2"] = None
    address_create["verify"] = True
    easypost.Address.create(**address_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_retrieve(address_create):
    address = easypost.Address.create(**address_create)
    easypost.Address.retrieve(address.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_addresses_list(page_size):
    easypost.Address.all(page_size=page_size)

    build_response_snippet()
