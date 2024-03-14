require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

rate = EasyPost::Rate.retrieve('rate...')

puts rate
