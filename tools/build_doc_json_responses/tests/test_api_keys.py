import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_api_keys_retrieve(prod_client):
    user = prod_client.user.retrieve_me()
    prod_client.api_keys.retrieve_api_keys_for_user(id=user.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_api_keys_create(referral_customer_prod_client):
    api_key = referral_customer_prod_client.api_keys.create(mode="test")

    try:
        build_response_snippet()
    finally:
        referral_customer_prod_client.api_keys.delete(id=api_key.id)


@pytest.mark.vcr()
def test_api_keys_delete(referral_customer_prod_client):
    api_key = referral_customer_prod_client.api_keys.create(mode="test")
    referral_customer_prod_client.api_keys.delete(id=api_key.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_api_keys_enable(referral_customer_prod_client):
    api_key = referral_customer_prod_client.api_keys.create(mode="test")
    referral_customer_prod_client.api_keys.disable(id=api_key.id)
    referral_customer_prod_client.api_keys.enable(id=api_key.id)

    try:
        build_response_snippet(interaction_index=2)
    finally:
        referral_customer_prod_client.api_keys.delete(id=api_key.id)


@pytest.mark.vcr()
def test_api_keys_disable(referral_customer_prod_client):
    api_key = referral_customer_prod_client.api_keys.create(mode="test")
    referral_customer_prod_client.api_keys.disable(id=api_key.id)

    try:
        build_response_snippet(interaction_index=1)
    finally:
        referral_customer_prod_client.api_keys.delete(id=api_key.id)
