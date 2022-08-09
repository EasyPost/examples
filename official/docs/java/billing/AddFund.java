import com.easypost.EasyPost;

public class AddFund {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        boolean success = Billing.fundWallet("2000", PaymentMethod.Priority.PRIMARY);

        System.out.println(success);
    }
}
