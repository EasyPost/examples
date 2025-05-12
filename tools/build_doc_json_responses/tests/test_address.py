import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_addresses_create(test_client, address_create):
    test_client.address.create(**address_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_create_and_verify(test_client, address_incorrect):
    try:
        test_client.address.create_and_verify(**address_incorrect)
    except Exception:
        # This will fail because the address is incorrect; this is expected.
        pass

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_verify_param(test_client, address_incorrect):
    address_incorrect["verify"] = True
    test_client.address.create(**address_incorrect)

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_verify_strict_param(test_client, address_incorrect):
    address_incorrect["verify_strict"] = True

    try:
        test_client.address.create(**address_incorrect)
    except Exception:
        # This will fail because the address is incorrect; this is expected.
        pass

    build_response_snippet()


@pytest.mark.vcr()
def test_addresses_verify(test_client, address_create):
    """Verify and already created address."""
    address = test_client.address.create(**address_create)
    test_client.address.verify(id=address.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_addresses_retrieve(test_client, address_create):
    address = test_client.address.create(**address_create)
    test_client.address.retrieve(id=address.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_addresses_list(test_client, page_size):
    test_client.address.all(page_size=page_size)

    build_response_snippet()
