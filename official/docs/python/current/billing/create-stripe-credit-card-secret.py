import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

response = client.beta_referral_customer.create_credit_card_client_secret()

print(response)
