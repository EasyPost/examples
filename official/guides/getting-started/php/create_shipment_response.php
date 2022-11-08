## Iterating through rates object printing out
## the carrier, service level, rate, and id
## of each possible rate.

foreach ($shipment->rates as $rate) {
  print_r($rate->carrier);
  print_r($rate->service);
  print_r($rate->rate);
  print_r($rate->id);
}
