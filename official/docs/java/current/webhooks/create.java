package webhooks;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Webhook;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> paramMap = new HashMap<String, Object>();
        paramMap.put("url", "example.com");

        Webhook webhook = client.webhook.create(paramMap);

        System.out.println(webhook);
    }
}
