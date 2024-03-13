import easypost

easypost.api_key = "EASYPOST_API_KEY"

refund = easypost.Refund.retrieve("rfnd_...")

print(refund)
