require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

trackers = EasyPost::Tracker.all(
  page_size: 5,
)

puts trackers
