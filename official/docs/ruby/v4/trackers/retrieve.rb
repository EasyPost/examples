require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

tracker = EasyPost::Tracker.retrieve('trk_...')

puts tracker
