get '/shipments/:shipment_id/zpl/print' do
  shipment = ::EasyPost::Shipment.retrieve(params['shipment_id'])
  printjob = PrintNode::PrintJob.new(
    settings.printer_id,
    shipment.id,
    'raw_uri',
    shipment.postage_label.label_zpl_url,
    'PrintLabel',
  )
  settings.printnode_client.create_printjob(printjob, {})
  redirect back
end
