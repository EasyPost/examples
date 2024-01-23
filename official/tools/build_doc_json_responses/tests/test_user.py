
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_child_users_create(prod_client):
    user = prod_client.user.create(name="Test User")

    # Delete the user so we don't clutter up the test environment
    prod_client.user.delete(id=user.id)

    build_response_snippet()


@pytest.mark.vcr()
def test_users_retrieve(prod_client):
    prod_client.user.retrieve_me()

    build_response_snippet()


@pytest.mark.vcr()
def test_users_update(prod_client):
    user = prod_client.user.retrieve_me()

    prod_client.user.update(id=user.id, phone="5555555555")

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_child_users_list(prod_client):
    prod_client.user.all_children()

    build_response_snippet()


@pytest.mark.vcr()
def test_child_users_delete(prod_client):
    user = prod_client.user.create(name="Test User")
    prod_client.user.delete(id=user.id)

    build_response_snippet(interaction_index=1)
