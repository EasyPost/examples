post '/shipment' do
  from_address = EasyPost::Address.new(ENV['FROM_ADDRESS_ID'])

  # If creation fails, you will need to catch EasyPost::Error. See the GitHub
  # repository or the Errors guide for examples.
  shipment = EasyPost::Shipment.create(
    from_address: from_address,
    to_address: params[:address],
    parcel: params[:parcel],
  )

  redirect "/shipment/#{shipment.id}/rates"
end
