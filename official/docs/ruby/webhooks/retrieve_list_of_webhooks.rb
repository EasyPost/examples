require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

webhooks = EasyPost::Webhook.all

puts webhooks
