require 'easypost'
require 'sinatra'

post '/easypost-webhook' do
  result = params['result']

  case result['object']
  when 'Batch'
    batch = EasyPost::Batch.new(result)

    case batch.state
    when 'purchase_failed'
      batch.shipments.each do |shipment|
        if shipment.batch_status == 'postage_purchase_failed'
          batch.remove_shipments([shipment])
        end
      end
    end
  end
end
