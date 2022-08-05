import com.easypost.EasyPost;

public class UpdateWebhook {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        webhook.update();

        System.out.println(webhook);
    }
}
