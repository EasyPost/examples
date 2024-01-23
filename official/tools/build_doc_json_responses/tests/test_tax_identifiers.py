
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_tax_identifiers_create(test_client, shipment_create, tax_identifier_create):
    shipment_data = shipment_create
    shipment_data["tax_identifiers"] = [tax_identifier_create]
    test_client.shipment.create(**shipment_data)

    build_response_snippet()
