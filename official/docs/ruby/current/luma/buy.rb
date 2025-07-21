# frozen_string_literal: true

require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_shipment = client.shipment.retrieve('shp_...')

shipment = client.shipment.buy_luma(
  retrieved_shipment.id,
  ruleset_name: 'required_deliver_by_date',
  planned_ship_date: '2025-07-16',
  deliver_by_date: '2025-07-18',
)

puts shipment
