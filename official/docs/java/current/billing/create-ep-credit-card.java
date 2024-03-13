package referral;

import com.easypost.exception.EasyPostException;
import com.easypost.service.EasyPostClient;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        String referralUserApiKey = System.getenv("REFERRAL_USER_API_KEY");

        PaymentMethodObject creditCard = client.referralCustomer.addCreditCardToUser(referralUserApiKey,
                "0123456789101234", 01, 2025, "111", PaymentMethod.Priority.PRIMARY);

        System.out.println(referralUser);
    }
}
