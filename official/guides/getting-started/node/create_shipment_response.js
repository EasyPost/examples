// Iterating through rates object printing out
// the carrier, service level, rate, and id
// of each possible rate.

shipment.rates.forEach((rate) => {
  console.log(rate.carrier);
  console.log(rate.service);
  console.log(rate.rate);
  console.log(rate.id);
});
