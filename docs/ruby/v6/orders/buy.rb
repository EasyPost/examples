require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

order = client.order.buy('order_...', carrier: 'FedEx', service: 'FEDEX_GROUND')

puts order
