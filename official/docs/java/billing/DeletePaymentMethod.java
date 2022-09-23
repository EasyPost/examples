package billing;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Billing;

public class DeletePaymentMethod {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        boolean success = Billing.deletePaymentMethod(com.easypost.model.PaymentMethod.Priority.PRIMARY);

        System.out.println(success);
    }
}
