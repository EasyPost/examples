require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

carrier_account = EasyPost::CarrierAccount.retrieve('ca_...')

carrier_account.delete

puts carrier_account
