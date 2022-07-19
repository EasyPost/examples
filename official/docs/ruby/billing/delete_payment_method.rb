require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

billing = EasyPost::Billing.delete('primary')

puts billing
