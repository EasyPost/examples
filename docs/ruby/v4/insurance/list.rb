require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

insurances = EasyPost::Insurance.all(
  page_size: 5,
)

puts insurances
