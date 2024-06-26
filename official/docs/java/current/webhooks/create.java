package webhooks;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Webhook;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("url", "example.com");
        paramMap.put("webhook_secret", "A1B2C3");

        Webhook webhook = client.webhook.create(params);

        System.out.println(webhook);
    }
}
