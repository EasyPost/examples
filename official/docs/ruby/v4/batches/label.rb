require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

batch = EasyPost::Batch.retrieve('batch_...')

batch.label(
  { file_format: 'PDF' },
)

puts batch
