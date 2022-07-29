import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class DeleteWebhook {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        webhook.delete();

        System.out.println(webhook);
    }
}
