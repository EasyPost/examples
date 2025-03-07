import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_returns_create(shipment_create):
    shipment_create["is_return"] = True
    easypost.Shipment.create(**shipment_create)

    build_response_snippet()
