post '/shipment/:id/buy' do
  shipment = EasyPost::Shipment.retrieve(params[:id])
  shipment.buy(rate: { id: params[:rate] })
  redirect "/shipment/#{shipment.id}"
end
