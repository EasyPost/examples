require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

webhook = EasyPost::Webhook.retrieve('hook_...')

webhook.delete

puts webhook
