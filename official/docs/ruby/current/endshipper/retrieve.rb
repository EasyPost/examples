require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

endshipper = client.end_shipper.retrieve('es_...')

puts endshipper
