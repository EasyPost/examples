package billing;

import com.easypost.exception.EasyPostException;
import com.easypost.model.PaymentMethod;
import com.easypost.service.EasyPostClient;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        PaymentMethod paymentMethods = client.billing.retrievePaymentMethods();

        System.out.println(paymentMethods);
    }
}
