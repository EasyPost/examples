require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

webhook = client.webhook.update('hook_...')

puts webhook
