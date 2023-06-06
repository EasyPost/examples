require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

# Request all metadata for all carriers
carrier_metadata = client.carrier_metadata.retrieve

# Request specific metadata for specific carriers
carrier_metadata = client.carrier_metadata.retrieve('usps', %w[service_levels predefined_packages])

puts carrier_metadata
