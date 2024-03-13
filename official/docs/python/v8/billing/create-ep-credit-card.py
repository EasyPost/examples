import easypost


client = easypost.EasyPostClient("EASYPOST_API_KEY")

credit_card = client.referral_customer.add_credit_card(
    referral_api_key="REFERRAL_USER_API_KEY",
    number="0123456789101234",
    expiration_month="01",
    expiration_year="2025",
    cvc="111",
)

print(credit_card)
