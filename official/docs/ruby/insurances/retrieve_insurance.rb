require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

insurance = EasyPost::Insurance.retrieve('ins_...')

puts insurance
