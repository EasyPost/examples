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


@pytest.mark.vcr()
def test_smartrate_retrieve_recommend_ship_date(test_client, shipment_create, next_week):
    shipment = test_client.shipment.create(**shipment_create)
    test_client.shipment.recommend_ship_date(
        id=shipment.id,
        desired_delivery_date=next_week,
    )

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_smartrate_retrieve_standalone_smartrate_deliver_by(test_client, next_week):
    test_client.smart_rate.estimate_delivery_date(
        from_zip="10001",
        to_zip="10002",
        planned_ship_date=next_week,
        carriers=["usps"],
    )

    build_response_snippet()


@pytest.mark.vcr()
def test_smartrate_retrieve_standalone_smartrate_deliver_on(test_client, next_week):
    test_client.smart_rate.recommend_ship_date(
        from_zip="10001",
        to_zip="10002",
        desired_delivery_date=next_week,
        carriers=["usps"],
    )

    build_response_snippet()
