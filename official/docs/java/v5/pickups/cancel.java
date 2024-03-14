package pickups;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Pickup;

public class Cancel {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        Pickup pickup = Pickup.retrieve("pickup_...");

        pickup = pickup.cancel();

        System.out.println(pickup);
    }
}
