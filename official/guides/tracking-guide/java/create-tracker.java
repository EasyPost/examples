// Creating a Tracker
Map<String, Object> params = new HashMap<String, Object>();
params.put("tracking_code","EZ4000000004");
params.put("carrier","UPS");
Tracker tracker = Tracker.create(params);
