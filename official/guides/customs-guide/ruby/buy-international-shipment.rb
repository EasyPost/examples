shipment.buy(
  rate: shipment.lowest_rate(['USPS'], ['First']),
)

# #OR

shipment.buy(rate: { id: '{RATE_ID}' })

## Print PNG link
puts shipment.postage_label.label_url

## Print Tracking Code
puts shipment.postage_label.tracking_code
