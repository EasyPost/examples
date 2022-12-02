package webhooks;

import com.easypost.exception.EasyPostException;
import com.easypost.model.WebhookCollection;
import com.easypost.service.EasyPostClient;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        WebhookCollection webhooks = client.webhook.all();

        System.out.println(webhooks);
    }
}
