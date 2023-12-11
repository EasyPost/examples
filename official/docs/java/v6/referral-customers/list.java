package referral;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ReferralCustomer;
import com.easypost.model.ReferralCustomerCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;
import java.util.List;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<String, Object>();

        params.put("page_size", 5);

        ReferralCustomerCollection referallCustomorCollection = client.referralCustomer.all(params);

        List<ReferralCustomer> referallUsers = referallCustomorCollection.getReferralCustomers();

        System.out.println(referallUsers);
    }
}
