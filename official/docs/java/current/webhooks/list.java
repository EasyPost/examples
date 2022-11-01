package webhooks;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Webhook;
import com.easypost.model.WebhookCollection;

public class List {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        WebhookCollection webhooks = Webhook.all();

        System.out.println(webhooks);
    }
}
