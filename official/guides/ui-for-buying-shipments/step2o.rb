get '/shipment/:id' do
  shipment = EasyPost::Shipment.retrieve(params[:id])
  erb :shipment, locals: { shipment: shipment }
end
