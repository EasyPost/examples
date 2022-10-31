package carrier_accounts;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierAccount;

import java.util.List;

public class RetrieveCarrierAccountList {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        List<CarrierAccount> carrierAccounts = CarrierAccount.all();

        System.out.println(carrierAccounts);
    }
}
