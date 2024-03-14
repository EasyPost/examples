require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_shipment = client.shipment.retrieve('shp_...')
end_shipper = client.end_shipper.retrieve('es_...')

shipment = client.shipment.buy(
  retrieved_shipment.id,
  rate: shipment.lowest_rate,
  insurance: nil,
  with_carbon_offset: false,
  end_shipper_id: end_shipper.id,
)

puts shipment
