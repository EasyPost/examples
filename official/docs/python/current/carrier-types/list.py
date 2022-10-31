import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

carrier_types = easypost.CarrierAccount.types()

print(carrier_types)
