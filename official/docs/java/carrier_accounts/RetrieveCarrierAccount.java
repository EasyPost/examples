package carrier_accounts;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierAccount;

public class RetrieveCarrierAccount {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        CarrierAccount carrierAccount = CarrierAccount.retrieve("ca_...");

        System.out.println(carrierAccount);
    }
}
