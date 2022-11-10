// If you already have a saved shipment, or a shipment initialized
// with an id:

shipment.buy(shipment.lowestRate(['USPS'], ['First'])).then(console.log);

// or

shipment.buy('{RATE_ID}').then(console.log);

// If you do not have a saved shipment yet, you must save it first:
shipment.save().then((s) => s.buy(shipment.lowestRate(['USPS'], ['First'])).then(console.log));
