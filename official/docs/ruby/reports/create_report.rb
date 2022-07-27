require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

report = EasyPost::Report.create(
  {
    start_date: '2016-10-01',
    end_date: '2016-10-31',
  },
)

puts report
