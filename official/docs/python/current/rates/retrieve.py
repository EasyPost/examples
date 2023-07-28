import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

rate = client.rate.retrieve("rate...")

print(rate)
