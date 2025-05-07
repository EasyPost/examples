require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

end_shipper = client.end_shipper.retrieve('es_...')

puts end_shipper
