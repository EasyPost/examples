require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

webhooks = EasyPost::Webhook.all

puts webhooks
