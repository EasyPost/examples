import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

referral_users = client.referral_customer.all(page_size=5)

print(referral_users)
