require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

client.billing.fund_wallet('2000', 'primary')
