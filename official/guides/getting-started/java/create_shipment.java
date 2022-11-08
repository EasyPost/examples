Map<String, Object> shipmentMap = new HashMap<String, Object>();
shipmentMap.put("to_address", toAddress);
shipmentMap.put("from_address", fromAddress);
shipmentMap.put("parcel", parcel);

Shipment shipment = Shipment.create(shipmentMap);
