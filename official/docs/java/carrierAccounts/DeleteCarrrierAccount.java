import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class DeleteCarrrierAccount {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        CarrierAccount carrierAccount = CarrierAccount.retrieve("ca_...");
        carrier_account.delete();

        system.out.println(carrierAccount);
    }
}
