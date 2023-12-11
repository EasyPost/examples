require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

end_shipper = client.end_shipper.retrieve('es_...')

puts end_shipper
