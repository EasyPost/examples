package referral;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveReferralUsers {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Billing.fundWallet("2000", PaymentMethod.Priority.PRIMARY);
    }
}
