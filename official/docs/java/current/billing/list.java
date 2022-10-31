package billing;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Billing;
import com.easypost.model.PaymentMethod;

public class RetrieveFund {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        PaymentMethod paymentMethods = Billing.retrievePaymentMethods();

        System.out.println(paymentMethods);
    }
}
