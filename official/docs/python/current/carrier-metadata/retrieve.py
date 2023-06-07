import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

# Request all metadata for all carriers
carrier_metadata = client.carrier_metadata.retrieve()

# Request specific metadata for specific carriers
carrier_metadata = client.carrier_metadata.retrieve(
    carriers=["usps"],
    types=["service_levels", "predefined_packages"],
)

print(carrier_metadata)
