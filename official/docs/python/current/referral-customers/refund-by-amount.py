import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

refund = client.beta_referral_customer.refund_by_amount(refund_amount=2000)

print(refund)
