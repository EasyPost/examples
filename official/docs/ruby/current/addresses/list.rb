require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

addresses = EasyPost::Address.all(
  page_size: 5,
)

puts addresses
