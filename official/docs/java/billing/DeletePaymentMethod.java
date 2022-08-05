import com.easypost.EasyPost;

public class DeletePaymentMethod {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        boolean success = Billing.deletePaymentMethod(PaymentMethod.Priority.PRIMARY);
    
        System.out.println(success);
    }
}
