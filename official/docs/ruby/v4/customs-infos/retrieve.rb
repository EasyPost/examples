require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

customs_info = EasyPost::CustomsInfo.retrieve('cstinfo_...')

puts customs_info
