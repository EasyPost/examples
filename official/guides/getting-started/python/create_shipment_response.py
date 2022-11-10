# Iterating through rates object printing out
# the carrier, service level, rate, and id
# of each possible rate.

for rate in shipment.rates:
    print(rate.carrier)
    print(rate.service)
    print(rate.rate)
    print(rate.id)
