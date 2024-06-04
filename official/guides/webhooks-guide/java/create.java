package webhooks_started;

import java.util.HashMap;

import com.easypost.service.EasyPostClient;
import com.easypost.exception.EasyPostException;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Map<String, Object> paramMap = new HashMap<String, Object>();
        paramMap.put("url", "https://example.com");
        paramMap.put("webhook_secret", "A1B2C3");

        Webhook webhook = client.webhook.create(paramMap);
    }
}
