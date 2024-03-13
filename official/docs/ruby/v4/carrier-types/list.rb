require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

carrier_types = EasyPost::CarrierAccount.types

puts carrier_types
