package billing;

import com.easypost.exception.EasyPostException;
import com.easypost.model.PaymentMethod;
import com.easypost.service.EasyPostClient;

public class CreateStripeCreditCardSecret {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        PaymentMethodObject paymentMethod = client.referralCustomer.addCreditCardFromStripe(
                "REFERRAL_USER_API_KEY",
                "seti_...",
                PaymentMethod.Priority.PRIMARY
        );

        System.out.println(paymentMethod);
    }
}
