require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

batch = EasyPost::Batch.retrieve('batch_...')

batch.create_scan_form

puts batch
