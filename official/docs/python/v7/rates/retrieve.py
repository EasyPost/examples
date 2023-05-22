import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

rate = easypost.Rate.retrieve("rate...")

print(rate)
