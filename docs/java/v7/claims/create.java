package claims;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Claim;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("type", "damage");
        params.put("email_evidence_attachments",
            new String[]{"REPLACE_WITH_BASE64_STRING"});
        params.put("invoice_attachments",
            new String[]{"REPLACE_WITH_BASE64_STRING"});
        params.put("supporting_documentation_attachments",
            new String[]{"REPLACE_WITH_BASE64_STRING"});
        params.put("description", "Test Description");
        params.put("contact_email", "test@example.com");
        params.put("tracking_code", "YOUR_TRACKING_CODE");
        params.put("amount", "100");

        Claim claim = client.claim.create(params);

        System.out.println(claim);
    }
}
