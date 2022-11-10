require 'easypost'
EasyPost.api_key = '<YOUR_PRODUCTION_API_KEY>'

EasyPost::Billing.fund('2000', 'primary')
