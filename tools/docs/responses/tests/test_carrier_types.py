import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_carrier_types_list(prod_api_key):
    easypost.CarrierAccount.types()

    build_response_snippet(objects_to_persist=3)
