package carrier_accounts;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierAccount;

import java.util.HashMap;

public class Update {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        CarrierAccount carrierAccount = CarrierAccount.retrieve("ca_...");

        HashMap<String, Object> credentials = new HashMap<String, Object>();
        credentials.put("pickup_id", "abc123");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("description", "FL Location DHL eCommerce Solutions Account");
        params.put("credentials", credentials);

        carrierAccount.update(params);

        System.out.println(carrierAccount);
    }
}
