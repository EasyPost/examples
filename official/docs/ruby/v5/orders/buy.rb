require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_order = client.order.retrieve('order_...')

order = client.order.buy(retrieved_order.id, carrier: 'FedEx', service: 'FEDEX_GROUND')

puts order
