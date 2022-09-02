import com.easypost.EasyPost;
import java.util.HashMap;

public class VerifyExistingAddress {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        HashMap<String, Object> addressParams = new HashMap<String, Object>();

        addressParams.put("street1", "417 Montgomery Street");
        addressParams.put("city", "SF");
        addressParams.put("state", "CA");
        addressParams.put("zip", "94104");
        addressParams.put("country", "US");
        addressParams.put("company", "EasyPost");
        addressParams.put("phone", "415-123-4567");
        addressParams.put("verify_strict", true);

        Address address = Address.create(addressParams);

        Address verifiedAddress = address.verify();

        System.out.println(verifiedAddress);
    }
}
