require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

scan_form = EasyPost::ScanForm.retrieve('sf_...')

puts scan_form
