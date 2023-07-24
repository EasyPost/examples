# Import the EasyPost client.
import easypost


# Setup the client with your API key.
easypost.api_key = "259DA788-39A3-439E-BA1E-BC541B8BA520"

# Calculate the carbon emissions and cost to offset carbon emissions.
shipment = easypost.Shipment.create(
    with_carbon_offset=True,
    to_address=to_address,
    from_address=from_address,
    parcel=parcel,
    customs_info=customs_info,
)
