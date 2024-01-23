
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_forms_create(test_client, shipment_one_call_buy, form_create):
    shipment = test_client.shipment.create(**shipment_one_call_buy)
    form_type = "return_packing_slip"
    test_client.shipment.generate_form(
        id=shipment.id,
        form_type=form_type,
        form_options=form_create,
    )

    build_response_snippet(interaction_index=1)
