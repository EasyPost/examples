require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

billing = EasyPost::Billing.fund('2000', 'primary')

puts billing
