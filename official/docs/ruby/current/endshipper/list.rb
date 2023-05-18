require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

endshippers = client.end_shipper.all(
  page_size: 5,
)

puts endshippers
