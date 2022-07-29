import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreateWebhook {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> paramMap = new HashMap<String, Object>();
        paramMap.put("url", "example.com");

        Webhook webhook = Webhook.create(paramMap);

        System.out.println(webhook);
    }
}
