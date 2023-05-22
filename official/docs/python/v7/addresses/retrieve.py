import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

address = easypost.Address.retrieve("adr_...")

print(address)
