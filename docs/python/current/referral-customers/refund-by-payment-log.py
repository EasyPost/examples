import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

refund = client.beta_referral_customer.refund_by_payment_log(payment_log_id="paylog_...")

print(refund)
