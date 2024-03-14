import easypost

easypost.api_key = "EASYPOST_API_KEY"

# Request all metadata for all carriers
carrier_metadata = easypost.beta.CarrierMetadata.retrieve_carrier_metadata()
print(carrier_metadata)

# Request specific metadata for specific carriers
carrier_metadata = easypost.beta.CarrierMetadata.retrieve_carrier_metadata(
    carriers=["usps"],
    types=["service_levels", "predefined_packages"],
)
print(carrier_metadata)
