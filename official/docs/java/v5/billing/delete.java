package billing;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Billing;
import com.easypost.model.PaymentMethod;

public class Delete {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        boolean success = Billing.deletePaymentMethod(PaymentMethod.Priority.PRIMARY);

        System.out.println(success);
    }
}
