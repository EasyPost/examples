require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

refund = client.beta_referral_customer.refund_by_payment_log('paylog_...')

puts refund
