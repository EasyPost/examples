import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

refund = easypost.beta.Referral.refund_by_payment_log(payment_log_id="paylog_...")

print(refund)
