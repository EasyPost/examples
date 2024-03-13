require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

webhook = EasyPost::Webhook.create(
  url: 'example.com',
)

puts webhook
