import com.easypost.EasyPost;

public class RetrievePickup {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Pickup pickup = Pickup.retrieve("pickup_...");

        System.out.println(pickup);
    }
}
