import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveFund {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        PaymentMethod paymentMethods = Billing.retrievePaymentMethods();

        System.out.println(paymentMethods);
    }
}
