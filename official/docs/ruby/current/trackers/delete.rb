require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

client.tracker.delete('trk_...')
