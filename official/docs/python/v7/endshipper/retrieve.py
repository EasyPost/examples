import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

retrieved_endshipper = easypost.EndShipper.retrieve("es_...")

print(retrieved_endshipper)
