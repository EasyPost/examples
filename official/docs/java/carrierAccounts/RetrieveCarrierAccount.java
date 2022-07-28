import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveCarrierAccount {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        CarrierAccount carrierAccount = CarrierAccount.retrieve("ca_...");

        System.out.println(carrierAccount);
    }
}
