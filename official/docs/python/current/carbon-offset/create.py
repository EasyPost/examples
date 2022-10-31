import easypost


easypost.api_key = "<YOUR_TEST/PRODUCTION_API_KEY>"

to_address = easypost.Address.create(...)
from_address = easypost.Address.create(...)
parcel = easypost.Parcel.create(...)
customs_info = easypost.CustomsInfo.create(...)

shipment = easypost.Shipment.create(
    with_carbon_offset=True, to_address=to_address, from_address=from_address, parcel=parcel, customs_info=customs_info
)
