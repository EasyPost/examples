import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_customs_items_create(test_client, customs_item_create):
    test_client.customs_item.create(**customs_item_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_customs_items_retrieve(test_client, customs_item_create):
    customs_item = test_client.customs_item.create(**customs_item_create)
    test_client.customs_item.retrieve(id=customs_item.id)

    build_response_snippet()
