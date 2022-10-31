import easypost


easypost.api_key = "<YOUR_TEST/PRODUCTION_API_KEY>"

to_address = easypost.Address.create(...)
from_address = easypost.Address.create(...)
parcel = easypost.Parcel.create(...)

# Reusing Easypost Objects

shipment = easypost.Shipment.create(
    with_carbon_offset=True,
    carrier_accounts=["ca_..."],
    service="NextDayAir",
    to_address=to_address,
    from_address=from_address,
    parcel=parcel,
)
