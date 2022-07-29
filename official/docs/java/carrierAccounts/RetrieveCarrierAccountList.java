import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveCarrierAccountList {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> listHash = new HashMap<String, Object>();
        listHash.put("type", "UpsAccount");

        List<CarrierAccount> carrierAccounts = CarrierAccount.all(listHash);

        System.out.println(carrierAccounts);
    }
}
