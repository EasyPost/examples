require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

refund = client.beta_referral_customer.refund_by_amount(2000)

puts refund
