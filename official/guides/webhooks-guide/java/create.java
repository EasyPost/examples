import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

EasyPost.apiKey = "<YOUR_TEST/PRODUCTION_API_KEY>";

Map<String, Object> paramMap = new HashMap<String, Object>();
paramMap.put("url", "https://example.com");
paramMap.put("webhook_secret", "A1B2C3");

Webhook webhook = Webhook.create(paramMap);
