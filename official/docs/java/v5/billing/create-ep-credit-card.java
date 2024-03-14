package referral;

import com.easypost.exception.EasyPostException;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        PaymentMethodObject creditCard = ReferralCustomer.addCreditCardToUser("REFERRAL_USER_API_KEY",
                "0123456789101234", 01, 2025, "111", PaymentMethod.Priority.PRIMARY);

        System.out.println(referralUser);
    }
}
