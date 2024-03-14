require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

report = EasyPost::Report.create(
  type: 'payment_log',
  start_date: '2022-10-01',
  end_date: '2022-10-31',
)

puts report
