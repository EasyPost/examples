require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

payment_method = client.beta_referral_customer.add_payment_method(
  'cus_...',
  'ba_...',
  'primary',
)

puts payment_method
