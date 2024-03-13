require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

refund = EasyPost::Beta::Referral.refund_by_amount(2000)

puts refund
