import com.easypost.EasyPost;

public class CreateAndVerifyAddress {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> addressHash = new HashMap<String, Object>();

        addressHash.put("street1", "417 Montgomery Street");
        addressHash.put("street2", "FL 5");
        addressHash.put("city", "San Francisco");
        addressHash.put("state", "CA");
        addressHash.put("zip", "94104");
        addressHash.put("country", "US");
        addressHash.put("company", "EasyPost");
        addressHash.put("phone", "415-123-4567");

        Address address = Address.createAndVerify(addressHash);

        System.out.println(address);
    }
}
