import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

insurances = client.insurance.all(page_size=5)

print(insurances)
