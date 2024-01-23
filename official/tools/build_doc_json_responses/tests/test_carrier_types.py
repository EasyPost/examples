import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_carrier_types_list(prod_client):
    prod_client.carrier_account.types()

    build_response_snippet(objects_to_persist=3)
