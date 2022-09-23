package billing;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Billing;
import com.easypost.model.PaymentMethod;

public class DeletePaymentMethod {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        boolean success = Billing.deletePaymentMethod(PaymentMethod.Priority.PRIMARY);

        System.out.println(success);
    }
}
