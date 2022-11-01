require 'easypost'

EasyPost.api_key = "<YOUR_TEST/PRODUCTION_API_KEY>"

shipment = EasyPost::Shipment.retrieve("shp_...")
shipment.buy(shipment.lowest_rate, true)
