post '/shipment' do
  from_address = client.address.create({})
  to_address = if params[:verify] == 'true'
                 client.address.create(
                   params[:address].merge(verify_strict: true),
                 )
               else
                 params[:address]
               end

  shipment = client.shipment.create(
    from_address: from_address,
    to_address: to_address,
    parcel: params[:parcel],
  )

  redirect "shipment/#{shipment.id}/rates"
end
