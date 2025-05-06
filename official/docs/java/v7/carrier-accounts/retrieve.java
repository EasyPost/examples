package carrier_accounts;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierAccount;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        CarrierAccount carrierAccount = client.carrierAccount.retrieve("ca_...");

        System.out.println(carrierAccount);
    }
}
