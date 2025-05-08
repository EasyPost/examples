require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

webhook = client.webhook.update(
  'hook_...', {
    webhook_secret: 'A1B2C3',
    custom_headers: [
      {
        name: 'X-Header-Name',
        value: 'header_value',
      }
    ],
  },
)

puts webhook
