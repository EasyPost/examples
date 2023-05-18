require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

scan_forms = client.scan_form.all(
  page_size: 5,
)

puts scan_forms
