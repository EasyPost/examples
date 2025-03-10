import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_endshipper_create(end_shipper_create):
    easypost.EndShipper.create(**end_shipper_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_endshipper_retrieve(end_shipper_create):
    endshipper = easypost.EndShipper.create(**end_shipper_create)

    easypost.EndShipper.retrieve(endshipper.id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_endshipper_list(page_size):
    easypost.EndShipper.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_endshipper_update(end_shipper_create):
    endshipper = easypost.EndShipper.create(**end_shipper_create)

    endshipper.name = "NEW NAME"
    endshipper.company = "BAZ"
    endshipper.street1 = "164 TOWNSEND STREET UNIT 1"
    endshipper.street2 = "UNIT 1"
    endshipper.city = "SAN FRANCISCO"
    endshipper.state = "CA"
    endshipper.zip = "94107"
    endshipper.country = "US"
    endshipper.phone = "555-555-5555"
    endshipper.email = "FOO@EXAMPLE.COM"
    endshipper = endshipper.save()

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_endshipper_buy(end_shipper_create, shipment_create):
    end_shipper = easypost.EndShipper.create(**end_shipper_create)
    shipment = easypost.Shipment.create(**shipment_create)
    shipment.buy(rate=shipment.lowest_rate(), end_shipper_id=end_shipper["id"])

    build_response_snippet(interaction_index=2)
