package rates;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Rate;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Rate rate = client.rate.retrieve("rate_...");

        System.out.println(rate);
    }
}
