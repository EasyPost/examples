shipment.buy(rate=shipment.lowest_rate(carriers=['USPS'], services=['First']))

##OR

shipment.buy(rate={'id': '{RATE_ID}'})
