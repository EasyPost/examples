require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

trackers = client.tracker.all(
  page_size: 5,
)

puts trackers
