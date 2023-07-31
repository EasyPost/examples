import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

addresses = easypost.Address.all(page_size=5)

print(addresses)
