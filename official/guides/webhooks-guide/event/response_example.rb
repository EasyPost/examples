require 'easypost'
require 'sinatra'

post '/easypost-webhook' do
  result = params['result']

  case result['object']
  when 'Batch'
    batch = client.batch.create(result)

    case batch.state
    when 'purchase_failed'
      batch.shipments.each do |shipment|
        if shipment.batch_status == 'postage_purchase_failed'
          client.batch.remove_shipments(batch.id, shipments: [shipment])
        end
      end
    end
  end
end
