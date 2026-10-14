import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_customs_infos_create(test_client, customs_info_create):
    test_client.customs_info.create(**customs_info_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_customs_infos_retrieve(test_client, customs_info_create):
    customs_info = test_client.customs_info.create(**customs_info_create)
    test_client.customs_info.retrieve(id=customs_info.id)

    build_response_snippet()
