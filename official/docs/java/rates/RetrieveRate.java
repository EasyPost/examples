package rates;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Rate;

public class RetrieveRate {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Rate rate = Rate.retrieve("rate_...");

        System.out.println(rate);
    }
}
