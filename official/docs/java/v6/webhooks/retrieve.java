package webhooks;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Webhook;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Webhook webhook = client.webhook.retrieve("hook_...");

        System.out.println(webhook);
    }
}
