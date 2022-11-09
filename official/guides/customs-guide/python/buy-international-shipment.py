shipment.buy(rate=shipment.lowest_rate(carriers=["USPS"], services=["First"]))

# OR

shipment.buy(rate={"id": "INSERT RATE ID HERE"})

# Print PNG link
print(shipment.postage_label.label_url)
# Print Tracking Code
print(shipment.postage_label.tracking_code)
