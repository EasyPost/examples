import com.easypost.EasyPost;

public class CancelPickup {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Pickup pickup = Pickup.retrieve("pickup_...");

        pickup = pickup.cancel();

        System.out.println(pickup);
    }
}
