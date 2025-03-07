import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_rates_retrieve(shipment_create):
    shipment = easypost.Shipment.create(**shipment_create)

    easypost.Rate.retrieve(shipment.rates[0].id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_rates_regenerate(shipment_create):
    shipment = easypost.Shipment.create(**shipment_create)
    shipment.regenerate_rates()

    build_response_snippet(interaction_index=1)
