import com.easypost.EasyPost;

public class DeleteCarrrierAccount {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        CarrierAccount carrierAccount = CarrierAccount.retrieve("ca_...");
        carrierAccount.delete();

        system.out.println(carrierAccount);
    }
}
