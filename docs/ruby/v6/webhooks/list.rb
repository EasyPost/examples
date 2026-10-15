require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

webhooks = client.webhook.all

puts webhooks
