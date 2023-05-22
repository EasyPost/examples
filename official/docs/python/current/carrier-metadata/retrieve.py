import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

# Request all metadata for all carriers
carrier_metadata = client.beta_carrier_metadata.retrieve_carrier_metadata()

# Request specific metadata for specific carriers
carrier_metadata = client.beta_carrier_metadata.retrieve_carrier_metadata(
    carriers=["usps"],
    types=["service_levels", "predefined_packages"],
)

print(carrier_metadata)
