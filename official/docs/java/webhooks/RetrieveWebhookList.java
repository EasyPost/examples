import com.easypost.EasyPost;

public class RetrieveWebhookList {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        WebhookCollection webhooks = Webhook.all();

        System.out.println(webhooks);
    }
}
