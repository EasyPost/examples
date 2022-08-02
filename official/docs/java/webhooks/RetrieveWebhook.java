import com.easypost.EasyPost;

public class RetrieveWebhook {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Webhook webhook = Webhook.retrieve("hook_...");

        System.out.println(webhook);
    }
}
