import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_parcels_create(parcel_create):
    easypost.Parcel.create(**parcel_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_parcels_retrieve(parcel_create):
    parcel = easypost.Parcel.create(**parcel_create)
    easypost.Parcel.retrieve(parcel.id)

    build_response_snippet()
