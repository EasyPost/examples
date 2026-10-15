package billing;

import com.easypost.exception.EasyPostException;
import com.easypost.service.EasyPostClient;

public class CreateStripeBankAccountSecret {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        ClientSecret response = client.betaReferralCustomer.createBankAccountClientSecret();

        System.out.println(response);
    }
}
