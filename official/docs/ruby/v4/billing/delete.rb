require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

success = EasyPost::Billing.delete('primary')

puts success
