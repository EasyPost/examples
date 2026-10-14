package webhooks;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Webhook;

public class Update {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        Webhook webhook = Webhook.retrieve("hook_...");
        webhook.update();

        System.out.println(webhook);
    }
}
