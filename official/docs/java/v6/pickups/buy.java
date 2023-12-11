package pickups;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Pickup;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Buy {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("carrier", "UPS");
        params.put("service", "Same-day Pickup");

        Pickup pickup = client.pickup.buy("pickup_...", params);

        System.out.println(pickup);
    }
}
