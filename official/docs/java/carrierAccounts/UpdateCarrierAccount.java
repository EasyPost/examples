import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class UpdateCarrierAccount {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        CarrierAccount carrierAccount = CarrierAccount.retrieve("ca_...");

        Map<String, Object> credentials = new HashMap<String, Object>();
        credentials.put("pickup_id", "abc123");
        
        Map<String, Object> params = new HashMap<String, Object>();
        params.put("credentials", credentials);
        
        carrierAccount.update(params);

        System.out.println(carrier_account);
    }
}
