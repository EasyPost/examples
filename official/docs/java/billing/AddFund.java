package billing;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Billing;

public class AddFund {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        boolean success = Billing.fundWallet("2000", com.easypost.model.PaymentMethod.Priority.PRIMARY);

        System.out.println(success);
    }
}
