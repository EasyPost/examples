get '/shipments/:shipment_id/zpl/generate' do
  shipment = client.shipment.retrieve(params['shipment_id'])
  client.shipment.label(shipment.id, file_format: 'ZPL') unless shipment.postage_label.label_zpl_url
  redirect back
end
