import easypost

easypost.api_key = "EASYPOST_API_KEY"

retrieved_endshipper = easypost.EndShipper.retrieve("es_...")

print(retrieved_endshipper)
