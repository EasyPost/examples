package referral;

import com.easypost.exception.EasyPostException;
import com.easypost.model.PaymentMethodObject;
import com.easypost.service.EasyPostClient;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        PaymentMethodObject paymentMethod = client.betaReferralCustomer.addPaymentMethod("cus_...", "ba_...");

        System.out.println(paymentMethod);
    }
}
