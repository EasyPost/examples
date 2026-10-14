import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

client.webhook.delete("hook_...")
