require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

refund = client.refund.retrieve('rfnd_...')

puts refund
