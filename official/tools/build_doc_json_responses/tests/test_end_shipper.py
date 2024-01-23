import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_endshipper_create(test_client, end_shipper_create):
    test_client.end_shipper.create(**end_shipper_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_endshipper_retrieve(test_client, end_shipper_create):
    endshipper = test_client.end_shipper.create(**end_shipper_create)

    test_client.end_shipper.retrieve(id=endshipper.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_endshipper_list(test_client, page_size):
    test_client.end_shipper.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_endshipper_update(test_client, end_shipper_create):
    endshipper = test_client.end_shipper.create(**end_shipper_create)

    test_client.end_shipper.update(id=endshipper.id,
                                   name="NEW NAME",
                                   company="BAZ",
                                   street1="164 TOWNSEND STREET UNIT 1",
                                   street2="UNIT 1",
                                   city="SAN FRANCISCO",
                                   state="CA",
                                   zip="94107",
                                   country="US",
                                   phone="555-555-5555",
                                   email="FOO@EXAMPLE.COM")

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_endshipper_buy(test_client, end_shipper_create, shipment_create):
    end_shipper = test_client.end_shipper.create(**end_shipper_create)
    shipment = test_client.shipment.create(**shipment_create)
    test_client.shipment.buy(id=shipment.id, end_shipper_id=end_shipper["id"], rate=shipment.lowest_rate())

    build_response_snippet(interaction_index=2)
