import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_brand_update(prod_client):
    user = prod_client.user.retrieve_me()
    prod_client.user.update_brand(id=user.id, color="#123456")

    build_response_snippet(interaction_index=1)
