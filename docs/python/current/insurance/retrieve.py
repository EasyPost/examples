import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

insurance = client.insurance.retrieve("ins_...")

print(insurance)
