import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

account_link = client.customer_portal.create_account_link(
    session_type="account_management",
    user_id="user_...",
    refresh_url="https://example.com/refresh",
    return_url="https://example.com/return",
    metadata={"target": "wallet"},
)

print(account_link)
