import com.easypost.EasyPost;

public class DeleteWebhook {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Webhook webhook = Webhook.retrieve("hook_...");
        webhook.delete();

        System.out.println(webhook);
    }
}
