import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

insurances = easypost.Insurance.all(page_size=5)

print(insurances)
