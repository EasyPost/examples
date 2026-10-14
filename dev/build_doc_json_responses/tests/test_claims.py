import pytest
from builder.snippets import build_response_snippet


def _prepare_insured_shipment(client, shipment_data, claim_amount):
    shipment = client.shipment.create(**shipment_data)
    _ = client.shipment.insure(shipment.id, amount=claim_amount)

    return shipment


@pytest.mark.vcr()
def test_claim_create(test_client, shipment_one_call_buy, claim_create):
    claim_amount = "100.00"
    insured_shipment = _prepare_insured_shipment(test_client, shipment_one_call_buy, claim_amount)
    claim_create["tracking_code"] = insured_shipment.tracking_code
    claim_create["amount"] = claim_amount
    test_client.claim.create(**claim_create)

    build_response_snippet(interaction_index=2)


@pytest.mark.vcr()
def test_claim_retrieve(test_client, shipment_one_call_buy, claim_create):
    claim_amount = "100.00"
    insured_shipment = _prepare_insured_shipment(test_client, shipment_one_call_buy, claim_amount)
    claim_create["tracking_code"] = insured_shipment.tracking_code
    claim_create["amount"] = claim_amount
    claim = test_client.claim.create(**claim_create)
    test_client.claim.retrieve(id=claim.id)

    build_response_snippet(interaction_index=3)


@pytest.mark.vcr()
def test_claim_list(test_client, page_size):
    test_client.claim.all(page_size=page_size)

    build_response_snippet()


@pytest.mark.vcr()
def test_claim_cancel(test_client, shipment_one_call_buy, claim_create):
    claim_amount = "100.00"
    insured_shipment = _prepare_insured_shipment(test_client, shipment_one_call_buy, claim_amount)
    claim_create["tracking_code"] = insured_shipment.tracking_code
    claim_create["amount"] = claim_amount
    claim = test_client.claim.create(**claim_create)
    test_client.claim.cancel(id=claim.id)

    build_response_snippet(interaction_index=3)
