require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

webhook = EasyPost::Webhook.retrieve('hook_...')

puts webhook
