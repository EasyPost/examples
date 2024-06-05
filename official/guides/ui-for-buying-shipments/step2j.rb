get '/shipment/:id/rates' do
  shipment = client.shipment.retrieve(params[:id])
  erb :rate, locals: { shipment: shipment }
end
