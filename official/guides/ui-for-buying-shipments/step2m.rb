post '/shipment' do
  from_address = EasyPost::Address.new(ENV['FROM_ADDRESS_ID'])
  to_address = if params[:verify] == 'true'
                 EasyPost::Address.create(
                   params[:address].merge(verify_strict: true),
                 )
               else
                 params[:address]
               end

  shipment = EasyPost::Shipment.create(
    from_address: from_address,
    to_address: to_address,
    parcel: params[:parcel],
  )

  redirect "shipment/#{shipment.id}/rates"
end
