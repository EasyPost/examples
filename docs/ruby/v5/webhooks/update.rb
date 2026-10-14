require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_webhook = client.webhook.retrieve('hook_...')

webhook = client.webhook.update(retrieved_webhook.id)

puts webhook
