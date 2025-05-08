require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

tracker = client.tracker.retrieve('trk_...')

puts tracker
