import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_returns_create(test_client, shipment_create):
    shipment_create["is_return"] = True
    test_client.shipment.create(**shipment_create)

    build_response_snippet()
