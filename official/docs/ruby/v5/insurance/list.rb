require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

insurances = client.insurance.all(
  page_size: 5,
)

puts insurances
