package referral;

import com.easypost.exception.EasyPostException;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        String referralUserApiKey = System.getenv("REFERRAL_USER_API_KEY");

        PaymentMethodObject creditCard = ReferralCustomer.addCreditCardToUser(referralUserApiKey,
                "0123456789101234", 01, 2028, "111", PaymentMethod.Priority.PRIMARY);

        System.out.println(referralUser);
    }
}
