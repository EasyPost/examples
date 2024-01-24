import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_insurance_create(test_client, insurance_create):
    test_client.insurance.create(**insurance_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_insurance_retrieve(test_client, page_size):
    insurances = test_client.insurance.all(page_size=page_size)
    test_client.insurance.retrieve(id=insurances["insurances"][0].id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_insurance_list(test_client, page_size):
    test_client.insurance.all(page_size=page_size)

    build_response_snippet()
