require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

metadata = client.beta_carrier_metadata.retrieve_carrier_metadata

puts metadata
