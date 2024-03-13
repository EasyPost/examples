require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

refund = client.refund.retrieve('rfnd_...')

puts refund
