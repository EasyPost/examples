require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

report = client.report.retrieve('<REPORT_ID>')

puts report
