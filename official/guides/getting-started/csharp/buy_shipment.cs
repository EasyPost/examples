shipment.Buy(shipment.LowestRate(
  includeServices: new List<string>() { "First" },
  excludeCarriers: new List<string>() { "USPS" }
));

// OR

shipment.Buy("{RATE_ID}");
