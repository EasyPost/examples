import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CancelPickup {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Pickup pickup = Pickup.retrieve("pickup_...");

        pickup = pickup.cancel();

        System.out.prntln(pickup);
    }
}
