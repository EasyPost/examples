shipment.Buy(shipment.LowestRate(
  includeServices: new List<string>() { "First" },
  excludeCarriers: new List<string>() { "USPS" }
));

// OR

shipment.Buy("{RATE_ID}");

// Print PNG link
System.Console.WriteLine(shipment.postage_label.label_url);
// Print Tracking Code
System.Console.WriteLine(shipment.postage_label.tracking_code);
