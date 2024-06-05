post '/shipment/:id/buy' do
  shipment = client.shipment.retrieve(params[:id])
  client.shipment.buy(shipment.id, rate: { id: params[:rate] })
  redirect "/shipment/#{shipment.id}"
end
