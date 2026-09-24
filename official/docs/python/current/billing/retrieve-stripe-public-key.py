import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

response = client.beta_referral_customer.retrieve_easypost_stripe_api_key()

print(response)
