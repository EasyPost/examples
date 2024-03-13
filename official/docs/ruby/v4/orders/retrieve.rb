require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

order = EasyPost::Order.retrieve('order_...')

puts order
