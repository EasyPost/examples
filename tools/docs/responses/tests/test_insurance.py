import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_insurance_create(insurance_create):
    easypost.Insurance.create(**insurance_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_insurance_retrieve(page_size):
    insurances = easypost.Insurance.all(page_size=page_size)
    easypost.Insurance.retrieve(insurances["insurances"][0].id)

    build_response_snippet(interaction_index=1)


@pytest.mark.vcr()
def test_insurance_list(page_size):
    easypost.Insurance.all(page_size=page_size)

    build_response_snippet()
