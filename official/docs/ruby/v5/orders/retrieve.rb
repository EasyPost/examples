require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

order = client.order.retrieve('order_...')

puts order
