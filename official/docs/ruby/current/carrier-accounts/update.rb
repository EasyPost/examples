require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

carrier_account = EasyPost::CarrierAccount.retrieve('ca_...')

carrier_account.description = 'FL Location DHL eCommerce Solutions Account'
carrier_account.credentials['pickup_id'] = 'abc123'

carrier_account.save

puts carrier_account
