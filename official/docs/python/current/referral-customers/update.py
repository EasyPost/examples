import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

client.referral_customer.update_email(
    "usr_...",
    "new_email@example.com",
)
