import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_smartrate_retrieve_time_in_transit_statistics(test_client, shipment_create):
    shipment = test_client.shipment.create(**shipment_create)
    test_client.shipment.get_smart_rates(id=shipment.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_smartrate_retrieve_estimated_delivery_date(test_client, shipment_create, next_weekday):
    shipment = test_client.shipment.create(**shipment_create)
    test_client.shipment.retrieve_estimated_delivery_date(
        id=shipment.id,
        planned_ship_date=next_weekday,
    )

    build_response_snippet(interaction_index=1)
