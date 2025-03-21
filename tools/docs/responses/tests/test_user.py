import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_child_users_create(prod_api_key):
    user = easypost.User.create(name="Test User")

    # Delete the user so we don't clutter up the test environment
    user.delete()

    build_response_snippet()


@pytest.mark.vcr()
def test_users_retrieve(prod_api_key):
    easypost.User.retrieve_me()

    build_response_snippet()


@pytest.mark.vcr()
def test_users_update(prod_api_key):
    user = easypost.User.retrieve_me()
    user.phone = "5555555555"
    user.save()

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_child_users_delete(prod_api_key):
    user = easypost.User.create(name="Test User")
    user.delete()

    build_response_snippet(interaction_index=1)
