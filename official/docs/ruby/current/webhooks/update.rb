require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

retrieved_webhook = client.webhook.retrieve('hook_...')

webhook.update(retrieved_webhook.id)

puts webhook
