import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

EasyPost.apiKey = "<YOUR_TEST/PRODUCTION_API_KEY>";

Map<String, Object> shipmentMap = new HashMap<String, Object>() {
  put("from_address", new HashMap<String, Object>() {
    put("company", "EasyPost");
    put("street1", "417 Montgomery Street");
    put("street2", "5th Floor");
    put("city", "San Francisco");
    put("state", "CA");
    put("zip", "94104");
    put("phone", "415-528-7555");
  });
  put("to_address", new HashMap<String, Object>() {
    put("name", "George Costanza");
    put("company", "Vandelay Industries");
    put("street1", "1 E 161st St.");
    put("city", "Bronx");
    put("state", "NY");
    put("zip", "10451");
  });
  put("parcel", new HashMap<String, Object>() {
    put("height", 9);
    put("width", 6);
    put("length", 2);
    put("weight", 10);
  });
};

Shipment shipment = Shipment.create(shipmentMap);

shipment.buy(shipment.lowestRate());
