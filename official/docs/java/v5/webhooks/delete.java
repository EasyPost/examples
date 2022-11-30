package webhooks;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Webhook;

public class Delete {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Webhook webhook = Webhook.retrieve("hook_...");
        webhook.delete();

        System.out.println(webhook);
    }
}
