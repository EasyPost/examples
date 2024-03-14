package carrier_accounts;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierAccount;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        HashMap<String, Object> credentials = new HashMap<String, Object>();
        credentials.put("client_id", "123456");
        credentials.put("client_secret", "123abc");
        credentials.put("distribution_center", "USLAX1");
        credentials.put("pickup_id", "123456");

        HashMap<String, Object> testCredentials = new HashMap<String, Object>();
        testCredentials.put("client_id", "123456");
        testCredentials.put("client_secret", "123abc");
        testCredentials.put("distribution_center", "USLAX1");
        testCredentials.put("pickup_id", "123456");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("type", "DhlEcsAccount");
        params.put("description", "CA Location DHL eCommerce Solutions Account");
        params.put("credentials", credentials);
        params.put("test_credentials", testCredentials);

        CarrierAccount carrierAccount = CarrierAccount.create(params);

        System.out.println(carrierAccount);
    }
}
