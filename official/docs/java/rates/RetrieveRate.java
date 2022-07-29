import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveRate {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Rate rate = Rate.retrieve("rate_...");

        System.out.prntln(pickup);
    }
}
