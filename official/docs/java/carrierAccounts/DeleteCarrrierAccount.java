import com.easypost.EasyPost;

public class DeleteCarrrierAccount {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        CarrierAccount carrierAccount = CarrierAccount.retrieve("ca_...");
        carrierAccount.delete();

        System.out.println(carrierAccount);
    }
}
