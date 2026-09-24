package billing;

import com.easypost.exception.EasyPostException;
import com.easypost.service.EasyPostClient;

public class RetrieveStripePublicKey {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Object response = client.betaReferralCustomer.retrieveEasypostStripeApiKey();

        System.out.println(response);
    }
}
