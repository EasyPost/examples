package referral;

import com.easypost.exception.EasyPostException;
import com.easypost.service.EasyPostClient;

public class Update {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        client.referralCustomer.updateEmail("new_email@example.com", "user_...");
    }
}
