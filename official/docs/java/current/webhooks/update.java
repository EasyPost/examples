package webhooks;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Webhook;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Update {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("webhook_secret", "A1B2C3");
        ArrayList<HashMap<String, String>> customHeaders = new ArrayList<>();
        HashMap<String, String> header = new HashMap<>();
        header.put("name", "X-Header-Name");
        header.put("value", "header_value");
        customHeaders.add(header);
        params.put("custom_headers", customHeaders);

        Webhook webhook = client.webhook.update("hook_...", params);

        System.out.println(webhook);
    }
}
