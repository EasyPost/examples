import com.easypost.EasyPost;
import java.util.List;

public class RetrieveCarrierAccountList {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        List<CarrierAccount> carrierAccounts = CarrierAccount.all();

        System.out.println(carrierAccounts);
    }
}
