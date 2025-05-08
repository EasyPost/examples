require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

# Request all metadata for all carriers
carrier_metadata = client.carrier_metadata.retrieve
puts carrier_metadata

# Request specific metadata for specific carriers
usps_carrier_metadata = client.carrier_metadata.retrieve('usps', %w[service_levels predefined_packages])
puts usps_carrier_metadata
