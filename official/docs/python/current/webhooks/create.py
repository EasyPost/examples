import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

webhook = client.webhook.create(url="example.com")

print(webhook)
