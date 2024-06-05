get '/shipments' do
  shipments = client.shipment.all
  erb :shipments, locals: { shipments: shipments }
end
