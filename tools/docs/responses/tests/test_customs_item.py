import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_customs_items_create(customs_item_create):
    easypost.CustomsItem.create(**customs_item_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_customs_items_retrieve(customs_item_create):
    customs_item = easypost.CustomsItem.create(**customs_item_create)
    easypost.CustomsItem.retrieve(customs_item.id)

    build_response_snippet()
