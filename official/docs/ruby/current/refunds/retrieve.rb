require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

refund = EasyPost::Refund.retrieve('rfnd_...')

puts refund
