
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_rates_retrieve(test_client, shipment_create):
    shipment = test_client.shipment.create(**shipment_create)

    test_client.rate.retrieve(id=shipment.rates[0].id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_rates_retrieve_stateless(test_client, shipment_create):
    test_client.beta_rate.retrieve_stateless_rates(**shipment_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_rates_regenerate(test_client, shipment_create):
    shipment = test_client.shipment.create(**shipment_create)
    test_client.shipment.regenerate_rates(id=shipment.id)

    build_response_snippet(interaction_index=1)
