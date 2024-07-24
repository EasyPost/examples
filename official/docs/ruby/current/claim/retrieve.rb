require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

claim = client.claim.retrieve('clm_...')

puts claim
