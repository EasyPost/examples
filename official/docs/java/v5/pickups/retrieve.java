package pickups;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Pickup;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        Pickup pickup = Pickup.retrieve("pickup_...");

        System.out.println(pickup);
    }
}
