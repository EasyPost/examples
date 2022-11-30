package referral;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ReferralCustomer;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<>();

        params.put("name", "test test");
        params.put("email", "test@test.com");
        params.put("phone", "8888888888");

        ReferralCustomer referralUser = client.referralCustomer.create(params);

        System.out.println(referralUser);
    }
}
