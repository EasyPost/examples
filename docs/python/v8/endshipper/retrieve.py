import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

retrieved_endshipper = client.end_shipper.retrieve("es_...")

print(retrieved_endshipper)
