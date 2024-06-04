package referral;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveReferralUsers {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Map<String, Object> params = new HashMap<String, Object>();
        params.put("recharge_threshold", "50.00");

        User me = client.user.retrieveMe();
        me = client.user.update(me.getId(), params);
    }
}
