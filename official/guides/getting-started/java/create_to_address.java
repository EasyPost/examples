Map<String, Object> toAddressMap = new HashMap<String, Object>();
addressMap.put("name", "George Costanza");
addressMap.put("company", "Vandelay Industries");
addressMap.put("street1", "1 E 161st St.");
addressMap.put("city", "Bronx");
addressMap.put("state", "NY");
addressMap.put("zip", "10451");

Address toAddress = Address.create(toAddressMap);
