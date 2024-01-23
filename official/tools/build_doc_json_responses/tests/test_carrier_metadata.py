import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_carrier_metadata_retrieve(test_client):
    test_client.carrier_metadata.retrieve(
        carriers=["usps"],
        types=["service_levels", "predefined_packages"],
    )

    build_response_snippet()
