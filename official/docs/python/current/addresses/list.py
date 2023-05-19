import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

addresses = client.address.all(page_size=5)

print(addresses)
