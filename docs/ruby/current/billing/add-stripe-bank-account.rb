require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

payment_method = client.referral_customer.add_bank_account_from_stripe(
  'REFERRAL_USER_API_KEY',
  'fca_...',
  {
    ip_address: '127.0.0.1',
    user_agent: 'Mozilla/5.0',
    accepted_at: 172_251_073,
  },
  'primary',
)

puts payment_method
