import com.easypost.EasyPost;

public class UpdateWebhook {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Webhook webhook = Webhook.retrieve("hook_...");
        webhook.update();

        System.out.println(webhook);
    }
}
