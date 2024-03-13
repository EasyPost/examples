require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

report = EasyPost::Report.retrieve('<REPORT_ID>')

puts report
