package webhooks;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Webhook;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        HashMap<String, Object> paramMap = new HashMap<String, Object>();
        paramMap.put("url", "example.com");

        Webhook webhook = Webhook.create(paramMap);

        System.out.println(webhook);
    }
}
