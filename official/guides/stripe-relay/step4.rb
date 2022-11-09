SHIPPING_ORIGIN_ADDRESS = {
  company: 'EasyPost',
  street1: '417 Montgomery St',
  street2: '5 FL',
  city: 'SAN FRANCISCO',
  state: 'CA',
  zip: '94104',
}.freeze

def easypost_shipment_from_stripe_order(order)
  EasyPost::Shipment.create(
    from_address: SHIPPING_ORIGIN_ADDRESS,
    to_address: easypost_address_from_stripe_shipping(order.shipping),
    parcel: { predefined_package: 'PARCEL', weight: stripe_order_weight(order) },
    options: { label_format: 'PDF' }, # custom options
  )
end

def easypost_address_from_stripe_shipping(shipping)
  {
    name: shipping.name,
    phone: shipping.phone,
    street1: shipping.address.line1,
    street2: shipping.address.line2,
    city: shipping.address.city,
    state: shipping.address.state,
    zip: shipping.address.postal_code,
    country: shipping.address.country,
  }
end

def stripe_order_weight(order)
  weight = 0
  order.items.each do |item|
    next unless item.type == 'sku'

    sku = Stripe::SKU.retrieve(id: item.parent, expand: ['product'])
    package_dimensions = sku.package_dimensions || sku.product.package_dimensions || { weight: 0 }
    weight += package_dimensions[:weight]
  end
  weight
end
