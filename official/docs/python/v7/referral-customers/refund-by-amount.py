import easypost

easypost.api_key = "EASYPOST_API_KEY"

refund = easypost.beta.Referral.refund_by_amount(refund_amount=2000)

print(refund)
