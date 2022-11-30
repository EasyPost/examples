package webhooks;

import com.easypost.exception.EasyPostException;
import com.easypost.service.EasyPostClient;

public class Delete {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        client.webhook.delete("hook_...");

        System.out.println(webhook);
    }
}
