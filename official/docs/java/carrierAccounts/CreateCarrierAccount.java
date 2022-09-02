import com.easypost.EasyPost;
import java.util.*;

public class CreateCarrierAccount {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> credentials = new HashMap<String, Object>();
        credentials.put("client_id", "123456");
        credentials.put("client_secret", "123abc");
        credentials.put("distribution_center", "USLAX1");
        credentials.put("pickup_id", "123456");

        Map<String, Object> testCredentials = new HashMap<String, Object>();
        testCredentials.put("client_id", "123456");
        testCredentials.put("client_secret", "123abc");
        testCredentials.put("distribution_center", "USLAX1");
        testCredentials.put("pickup_id", "123456");

        Map<String, Object> params = new HashMap<String, Object>();
        params.put("type", "DhlEcsAccount");
        params.put("description", "CA Location DHL eCommerce Solutions Account");
        params.put("credentials", credentials);
        params.put("test_credentials", testCredentials);

        CarrierAccount carrierAccount = CarrierAccount.create(params);

        System.out.println(carrierAccount);
    }
}
