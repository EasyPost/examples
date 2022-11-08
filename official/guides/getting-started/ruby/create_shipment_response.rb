## Iterating through rates object printing out
## the carrier, service level, rate, and id
## of each possible rate.

shipment.rates.each do |rate|
  puts(rate.carrier)
  puts(rate.service)
  puts(rate.rate)
  puts(rate.id)
end
