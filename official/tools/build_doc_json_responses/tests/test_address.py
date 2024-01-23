import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_addresses_create(test_client, address_create):
    test_client.address.create(**address_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_create_and_verify(test_client, address_create_and_verify):
    test_client.address.create_and_verify(**address_create_and_verify)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_verify_param(test_client, address_create):
    address_create["verify"] = True
    test_client.address.create(**address_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_verify_strict_param(test_client, address_create):
    address_create["verify_strict"] = True
    test_client.address.create(**address_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_verify(test_client, address_create):
    """Verify and already created address."""
    address = test_client.address.create(**address_create)
    test_client.address.verify(id=address.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_addresses_verify_failure(test_client, address_create):
    """Verify and already created address."""
    address_create["street1"] = "UNDELIVERABLE ST"
    address_create["street2"] = None
    address_create["verify"] = True
    test_client.address.create(**address_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_retrieve(test_client, address_create):
    address = test_client.address.create(**address_create)
    test_client.address.retrieve(id=address.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_addresses_list(test_client, page_size):
    test_client.address.all(page_size=page_size)

    build_response_snippet()
