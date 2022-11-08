package referral;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.ReferralCustomer;

public class UpdateReferralUser {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        ReferralCustomer.updateEmail("new_email@example.com", "user_...");
    }
}
