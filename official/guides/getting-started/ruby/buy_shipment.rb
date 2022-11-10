shipment.buy(
  rate: shipment.lowest_rate(['USPS'], ['First']),
)

# #OR

shipment.buy(rate: { id: '{RATE_ID}' })
