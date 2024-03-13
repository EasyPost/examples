package referral;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.ReferralCustomer;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        HashMap<String, Object> params = new HashMap<>();

        params.put("name", "test test");
        params.put("email", "test@test.com");
        params.put("phone", "8888888888");

        ReferralCustomer referralUser = ReferralCustomer.create(params);

        System.out.println(referralUser);
    }
}
