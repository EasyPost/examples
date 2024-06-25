import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

end_shipper = client.end_shipper.retrieve("es_...")

print(end_shipper)
