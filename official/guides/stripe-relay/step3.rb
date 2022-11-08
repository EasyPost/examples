def select_easypost_rate_for_stripe_order(order, shipment)
  if order.selected_shipping_method&.start_with?('rate_')
    EasyPost::Rate.new(order.selected_shipping_method)
  else
    shipment.lowest_rate('USPS')
  end
end
