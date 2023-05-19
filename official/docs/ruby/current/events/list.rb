require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

events = client.event.all(
  page_size: 5,
)

puts events
