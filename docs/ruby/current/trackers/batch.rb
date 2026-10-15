require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

trackers = client.tracker.retrieve_batch(
  tracking_codes: %w[EZ1000000001 EZ1000000002],
)

puts trackers
