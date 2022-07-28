import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreatePickup {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        HashMap<String, Object> address = new HashMap<String, Object>();
        fromAddress.put("id", "adr_...");
        
        HashMap<String, Object> shipment = new HashMap<String, Object>();
        fromAddress.put("id", "shp_...");
        
        Map<String, Object> pickupMap = new HashMap<String, Object>();
        pickupMap.put("address", address);
        pickupMap.put("shipment", shipment);
        pickupMap.put("reference", "my-first-pickup");
        pickupMap.put("min_datetime", "2014-10-20 17:10:00");
        pickupMap.put("max_datetime", "2014-10-21 10:30:00");
        pickupMap.put("is_account_address", false);
        pickupMap.put("instructions", "Special pickup instructions");
        
        Pickup pickup = Pickup.create(pickupMap);
        
        System.out.prntln(pickup);
    }
}
