require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

refund = client.beta_referral_customer.refund_by_amount(2000)

puts refund
