import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_smartrate_retrieve_time_in_transit_statistics(shipment_create):
    shipment = easypost.Shipment.create(**shipment_create)
    shipment.get_smartrates()

    build_response_snippet(interaction_index=1)
