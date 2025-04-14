import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_parcels_create(test_client, parcel_create):
    test_client.parcel.create(**parcel_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_parcels_retrieve(test_client, parcel_create):
    parcel = test_client.parcel.create(**parcel_create)
    test_client.parcel.retrieve(id=parcel.id)

    build_response_snippet()
