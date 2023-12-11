require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

end_shippers = client.end_shipper.all(
  page_size: 5,
)

puts end_shippers
