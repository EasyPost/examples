require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

customs_item = client.customs_item.retrieve('cstitem_...')

puts customs_item
