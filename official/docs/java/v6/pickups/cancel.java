package pickups;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Pickup;
import com.easypost.service.EasyPostClient;

public class Cancel {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Pickup pickup = client.pickup.cancel("pickup_...");

        System.out.println(pickup);
    }
}
