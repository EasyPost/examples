require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

claims = client.claim.all(
  page_size: 5,
)

puts claims
