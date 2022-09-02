import com.easypost.EasyPost;
import java.util.HashMap;

public class BuyPickup {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Pickup pickup = Pickup.retrieve("pickup_...");

        HashMap<String, Object> buyMap = new HashMap<String, Object>();
        buyMap.put("carrier", "UPS");
        buyMap.put("service", "Same-day Pickup");

        pickup = pickup.buy(buyMap);

        System.out.println(pickup);
    }
}
