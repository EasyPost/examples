require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

customs_item = EasyPost::CustomsItem.retrieve('cstitem_...')

puts customs_item
