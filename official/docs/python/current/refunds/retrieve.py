import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

refund = client.refund.retrieve("rfnd_...")

print(refund)
