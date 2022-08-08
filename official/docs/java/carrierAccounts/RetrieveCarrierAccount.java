import com.easypost.EasyPost;

public class RetrieveCarrierAccount {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        CarrierAccount carrierAccount = CarrierAccount.retrieve("ca_...");

        System.out.println(carrierAccount);
    }
}
