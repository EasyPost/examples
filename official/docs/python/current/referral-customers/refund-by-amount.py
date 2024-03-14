import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

refund = client.beta_referral_customer.refund_by_amount(refund_amount=2000)

print(refund)
