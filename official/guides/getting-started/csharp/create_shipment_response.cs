// Iterating through rates object printing out
// the carrier, service level, rate, and id
// of each possible rate.

foreach(Rate rate in shipment.rates) {
  System.Console.WriteLine(rate.carrier);
  System.Console.WriteLine(rate.service);
  System.Console.WriteLine(rate.rate);
  System.Console.WriteLine(rate.id);
}
