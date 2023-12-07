package carrier_accounts;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierAccount;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Update {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> credentials = new HashMap<String, Object>();
        credentials.put("pickup_id", "abc123");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("description", "FL Location DHL eCommerce Solutions Account");
        params.put("credentials", credentials);

        CarrierAccount carrierAccount = client.carrierAccount.update("ca_...", params);

        System.out.println(carrierAccount);
    }
}
