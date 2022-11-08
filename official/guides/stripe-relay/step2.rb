def main
  Stripe::Order.list(status: 'paid', limit: 10).data.each do |paid_order|
    puts "\nFulfilling #{paid_order.id}..."

    # the Stripe Order.id is automatically sent to EasyPost as a Shipment.reference
    shipment = EasyPost::Shipment.retrieve(paid_order.id)

    selected_rate = select_easypost_rate_for_stripe_order(paid_order, shipment)

    begin
      shipment.buy(selected_rate)
    rescue EasyPost::Error => e
      puts "Unable to fulfill #{paid_order.id}: #{e.message}"
      next
    end

    puts "Tracking code: #{shipment.tracking_code}"
    puts "Shipping label: #{shipment.postage_label.label_url}"

    paid_order.status = 'fulfilled'
    paid_order.metadata['shipping_tracking_code'] = shipment.tracking_code
    paid_order.save
  end
end
