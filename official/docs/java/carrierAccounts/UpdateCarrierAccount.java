import com.easypost.EasyPost;
import java.util.HashMap;

public class UpdateCarrierAccount {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        CarrierAccount carrierAccount = CarrierAccount.retrieve("ca_...");

        HashMap<String, Object> credentials = new HashMap<String, Object>();
        credentials.put("pickup_id", "abc123");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("credentials", credentials);

        carrierAccount.update(params);

        System.out.println(carrierAccount);
    }
}
