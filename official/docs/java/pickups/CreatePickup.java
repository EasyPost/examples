import com.easypost.EasyPost;
import java.util.HashMap;

public class CreatePickup {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        HashMap<String, Object> address = new HashMap<String, Object>();
        fromAddress.put("id", "adr_...");

        HashMap<String, Object> shipment = new HashMap<String, Object>();
        fromAddress.put("id", "shp_...");

        HashMap<String, Object> pickupMap = new HashMap<String, Object>();
        pickupMap.put("address", address);
        pickupMap.put("shipment", shipment);
        pickupMap.put("reference", "my-first-pickup");
        pickupMap.put("min_datetime", "2022-10-01 10:30:00");
        pickupMap.put("max_datetime", "2022-10-02 10:30:00");
        pickupMap.put("is_account_address", false);
        pickupMap.put("instructions", "Special pickup instructions");

        Pickup pickup = Pickup.create(pickupMap);

        System.out.println(pickup);
    }
}
