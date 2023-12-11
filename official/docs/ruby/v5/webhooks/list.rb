require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

webhooks = client.webhook.all

puts webhooks
