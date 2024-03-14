import easypost

easypost.api_key = "EASYPOST_API_KEY"

referral_users = easypost.Referral.all(page_size=5)

print(referral_users)
