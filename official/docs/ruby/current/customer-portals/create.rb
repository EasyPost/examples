require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

account_link = client.customer_portal.create_account_link(
  {
    session_type: 'account_management',
    user_id: 'user_...',
    refresh_url: 'https://example.com/refresh',
    return_url: 'https://example.com/return',
    metadata: { target: 'wallet' },
  },
)

puts account_link
