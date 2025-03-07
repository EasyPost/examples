import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_customs_infos_create(customs_info_create):
    easypost.CustomsInfo.create(**customs_info_create)

    build_response_snippet()


@pytest.mark.vcr()
def test_customs_infos_retrieve(customs_info_create):
    customs_info = easypost.CustomsInfo.create(**customs_info_create)
    easypost.CustomsInfo.retrieve(customs_info.id)

    build_response_snippet()
