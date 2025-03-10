import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_forms_create(shipment_one_call_buy, form_create):
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    form_type = "return_packing_slip"
    shipment.generate_form(
        form_type,
        form_create,
    )

    build_response_snippet(interaction_index=1)
