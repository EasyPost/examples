import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

insurances = client.insurance.all(page_size=5)

print(insurances)
