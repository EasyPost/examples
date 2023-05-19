require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

order = client.order.retrieve('order_...')

puts order
