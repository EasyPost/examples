require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

rate = EasyPost::Rate.retrieve('shp...')

puts rate
