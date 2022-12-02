package carrier_accounts;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierAccount;
import com.easypost.service.EasyPostClient;

import java.util.List;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        List<CarrierAccount> carrierAccounts = client.carrierAccount.all();

        System.out.println(carrierAccounts);
    }
}
