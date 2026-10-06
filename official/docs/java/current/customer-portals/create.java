package customer_portals;

import java.util.HashMap;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CustomerPortalAccountLink;
import com.easypost.service.EasyPostClient;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<>();
        params.put("session_type", "account_management");
        params.put("user_id", "user_...");
        params.put("refresh_url", "https://example.com/refresh");
        params.put("return_url", "https://example.com/return");

        HashMap<String, Object> metadata = new HashMap<>();
        metadata.put("target", "wallet");
        params.put("metadata", metadata);

        CustomerPortalAccountLink accountLink = client.customerPortal.createAccountLink(params);

        System.out.println(accountLink);
    }
}
