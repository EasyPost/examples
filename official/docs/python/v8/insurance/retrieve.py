import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

insurance = client.insurance.retrieve("ins_...")

print(insurance)
