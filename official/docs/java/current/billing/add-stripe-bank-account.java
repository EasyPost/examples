package billing;

import com.easypost.exception.EasyPostException;
import com.easypost.model.PaymentMethod;
import com.easypost.service.EasyPostClient;

public class CreateStripeCreditCardSecret {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> mandateData = new HashMap<String, Object>();
        mandateData.put("ip_address", "127.0.0.1");
        mandateData.put("user_agent", "Mozilla/5.0");
        mandateData.put("accepted_at", 1722510730);

        PaymentMethodObject paymentMethod = client.referralCustomer.addBankAccountFromStripe(
                "REFERRAL_USER_API_KEY",
                "fca_...",
                mandateData,
                PaymentMethod.Priority.PRIMARY
        );

        System.out.println(paymentMethod);
    }
}
