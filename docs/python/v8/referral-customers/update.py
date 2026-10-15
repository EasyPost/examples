import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

user = client.user.retrieve("usr_...")

client.referral_customer.update_email(
    user.id,
    "new_email@example.com",
    "user_...",
)
