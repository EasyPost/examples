import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreateVerifiedAddress {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> addressHash = new HashMap<String, Object>();

        addressHash.put("street1", "417 Montgomery Street");
        addressHash.put("street2", "5");
        addressHash.put("city", "SF");
        addressHash.put("state", "CA");
        addressHash.put("zip", "94104");
        addressHash.put("country", "US");
        addressHash.put("company", "EasyPost");
        addressHash.put("phone", "415-123-4567");
        addressHash.put("verify", true);

        Address address = Address.create(addressHash);

        System.out.println(address);
    }
}
