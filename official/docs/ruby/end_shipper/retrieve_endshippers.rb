require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

endshippers = EasyPost::EndShipper.all(
  page_size: 5,
)

puts endshippers
