import easypost
import pytest
from builder.snippets import build_response_snippet


@pytest.mark.vcr()
def test_shipping_insurance_insure(shipment_one_call_buy):
    """Set insurnace to `0` when buying a shipment.

    If the shipment was purchased with a USPS rate, it must have had its insurance set to `0` when bought
    so that USPS doesn't automatically insure it so we could manually insure it here.
    """
    # Set to 0 so USPS doesn't insure this automatically and we can insure the shipment manually
    shipment_one_call_buy["insurance"] = 0
    shipment = easypost.Shipment.create(**shipment_one_call_buy)
    shipment.insure(amount="100")

    build_response_snippet(interaction_index=1)
