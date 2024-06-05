require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

EasyPost::Billing.fund_wallet('2000', 'primary')
