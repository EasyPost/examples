require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

scan_forms = EasyPost::ScanForm.all(
  { page_size: 5 },
)

puts scan_forms
