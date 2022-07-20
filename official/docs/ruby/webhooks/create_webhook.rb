require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

webhook = EasyPost::Webhook.create(
  { url: 'example.com' },
)

puts webhook
