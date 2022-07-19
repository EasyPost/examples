require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

key = EasyPost::ApiKey.delete('api...')

puts key
