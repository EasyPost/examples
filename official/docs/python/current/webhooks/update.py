import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

updated_webhook = client.webhook.update(
    "hook_...",
    webhook_secret="A1B2C3",
    custom_headers=[
        {
            "name": "X-Header-Name",
            "value": "header_value",
        }
    ],
)

print(updated_webhook)
