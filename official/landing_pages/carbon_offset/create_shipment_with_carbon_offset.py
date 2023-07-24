import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

# Calculate the carbon emissions and cost to offset carbon emissions
shipment = easypost.Shipment.create(
    with_carbon_offset=True,
    to_address=to_address,
    from_address=from_address,
    parcel=parcel,
    customs_info=customs_info,
)
