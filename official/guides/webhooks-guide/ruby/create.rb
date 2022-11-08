require 'easypost'
EasyPost.api_key = '<YOUR_TEST/PRODUCTION_API_KEY>'

EasyPost::Webhook.create(
  url: 'http://example.com',
  webhook_secret: 'A1B2C3',
)
