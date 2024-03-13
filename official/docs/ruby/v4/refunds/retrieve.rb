require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

refund = EasyPost::Refund.retrieve('rfnd_...')

puts refund
