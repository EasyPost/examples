get '/shipments' do
  shipments = ::EasyPost::Shipment.all({})
  erb :shipments, locals: { shipments: shipments }
end
