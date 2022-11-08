// Iterating through rates object printing out
// the carrier, service level, rate, and id
// of each possible rate.

for(Rate rate : shipment.rates) {
  System.out.println(rate.carrier);
  System.out.println(rate.service);
  System.out.println(rate.rate);
  System.out.println(rate.id);
}
