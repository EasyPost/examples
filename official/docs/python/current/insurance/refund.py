import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

insurance = client.insurance.refund("ins_...")

print(insurance)
