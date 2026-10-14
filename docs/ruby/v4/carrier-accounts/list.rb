require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

carrier_accounts = EasyPost::CarrierAccount.all

puts carrier_accounts
