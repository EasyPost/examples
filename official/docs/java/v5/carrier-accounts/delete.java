package carrier_accounts;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierAccount;

public class Delete {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        CarrierAccount carrierAccount = CarrierAccount.retrieve("ca_...");
        carrierAccount.delete();

        System.out.println(carrierAccount);
    }
}
