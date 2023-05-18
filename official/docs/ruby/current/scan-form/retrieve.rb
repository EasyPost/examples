require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

scan_form = client.scan_form.retrieve('sf_...')

puts scan_form
