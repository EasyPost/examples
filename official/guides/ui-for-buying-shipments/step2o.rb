get '/shipment/:id' do
  shipment = client.shipment.retrieve(params[:id])
  erb :shipment, locals: { shipment: shipment }
end
