import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

insurance = easypost.Insurance.create(
    to_address={"id": "adr_..."},
    from_address={"id": "adr_..."},
    tracking_code="9400110898825022579493",
    carrier="USPS",
    amount="100.00",
    reference="insuranceRef1",
)

print(insurance)
