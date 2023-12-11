require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

tracker = client.tracker.retrieve('trk_...')

puts tracker
