import com.easypost.EasyPost;

public class RetrieveFund {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        PaymentMethod paymentMethods = Billing.retrievePaymentMethods();

        System.out.println(paymentMethods);
    }
}
