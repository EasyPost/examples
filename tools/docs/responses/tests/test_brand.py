import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_brand_update(prod_api_key):
    user = easypost.User.retrieve_me()
    user.update_brand(color="#123456")

    build_response_snippet(interaction_index=1)
