import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_carrier_metadata_retrieve(test_client):
    test_client.carrier_metadata.retrieve(
        carriers=["uspsbyoca"],
    )

    build_response_snippet()
