import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveWebhookList {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        WebhookCollection webhooks = Webhook.all();
        
        System.out.println(webhook);
    }
}
