package webhooks_started;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Map<String, Object> paramMap = new HashMap<String, Object>();
        paramMap.put("url", "https://example.com");
        paramMap.put("webhook_secret", "A1B2C3");

        Webhook webhook = Webhook.create(paramMap);
    }
}
