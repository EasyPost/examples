import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class UpdateWebhook {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        webhook.update();

        System.out.println(webhook);
    }
}
