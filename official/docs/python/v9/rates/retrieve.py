import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

rate = client.rate.retrieve("rate...")

print(rate)
