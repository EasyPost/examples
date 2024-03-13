require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

address = EasyPost::Address.retrieve('adr_...')

puts address
