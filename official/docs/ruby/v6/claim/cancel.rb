require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

claim = client.claim.cancel('clm_...')

puts claim
