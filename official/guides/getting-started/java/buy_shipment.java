List<String> buyCarriers = new ArrayList<String>();
buyCarriers.add("USPS");
List<String> buyServices = new ArrayList<String>();
buyServices.add("First");
shipment.buy(shipment.lowestRate(buyCarriers, buyServices));

//OR

Map<String, Object> rate = new HashMap<String, Object>();
rate.put("id", "{RATE_ID}");
shipment.buy(rate);

