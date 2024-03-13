package webhooks;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Webhook;
import com.easypost.model.WebhookCollection;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        WebhookCollection webhooks = Webhook.all();

        System.out.println(webhooks);
    }
}
