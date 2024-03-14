require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

payment_methods = client.billing.retrieve_payment_methods

puts payment_methods
