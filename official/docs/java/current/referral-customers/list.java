package referral;

import java.util.HashMap;
import java.util.List;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.ReferralCustomer;
import com.easypost.model.ReferralCustomerCollection;

public class List {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();

        params.put("page_size", 5);

        ReferralCustomerCollection referallCustomorCollection = ReferralCustomer.all(params);

        List<ReferralCustomer> referallUsers = referallCustomorCollection.getReferralCustomers();

        System.out.println(referallUsers);
    }
}
