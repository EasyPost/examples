import com.easypost.EasyPost;

public class DeleteWebhook {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        webhook.delete();

        System.out.println(webhook);
    }
}
