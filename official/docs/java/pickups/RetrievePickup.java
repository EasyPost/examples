package pickups;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Pickup;

public class RetrievePickup {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Pickup pickup = Pickup.retrieve("pickup_...");

        System.out.println(pickup);
    }
}
