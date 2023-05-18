require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

webhook = client.webhook.create(
  url: 'example.com',
)

puts webhook
