get '/shipment/:id/rates' do
  shipment = EasyPost::Shipment.retrieve(params[:id])
  erb :rate, locals: { shipment: shipment }
end
