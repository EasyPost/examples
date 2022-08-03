import com.easypost.EasyPost;

public class VerifyExistingAddress {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> addressHash = new HashMap<String, Object>();

        addressHash.put("street1", "417 Montgomery Street");
        addressHash.put("city", "SF");
        addressHash.put("state", "CA");
        addressHash.put("zip", "94104");
        addressHash.put("country", "US");
        addressHash.put("company", "EasyPost");
        addressHash.put("phone", "415-123-4567");
        addressHash.put("verify_strict", true);

        Address address = Address.create(addressHash);

        Address verifiedAddress = address.verify();

        System.out.println(verifiedAddress);
    }
}
