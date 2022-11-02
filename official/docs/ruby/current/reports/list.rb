require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

reports = EasyPost::Report.all(
  # Replace `payment_log` with any of the report types listed above
  type: 'payment_log',
  page_size: 5,
)

puts reports
