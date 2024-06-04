package referral;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveReferralUsers {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        client.billing.fundWallet("2000", PaymentMethod.Priority.PRIMARY);
    }
}
