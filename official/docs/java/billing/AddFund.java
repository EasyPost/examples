import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class AddFund {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        boolean success = Billing.fundWallet("2000", PaymentMethod.Priority.PRIMARY);

        System.out.println(success);
    }
}
