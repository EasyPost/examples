get '/shipments/:shipment_id/zpl/generate' do
  shipment = ::EasyPost::Shipment.retrieve(params['shipment_id'])
  shipment.label(file_format: 'ZPL') unless shipment.postage_label.label_zpl_url
  redirect back
end
