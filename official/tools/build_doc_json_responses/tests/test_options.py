import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_options_create_with_options(test_client, shipment_create):
    shipment_create["options"] = {"print_custom_1": "Custom label message"}
    test_client.shipment.create(**shipment_create)

    build_response_snippet()
