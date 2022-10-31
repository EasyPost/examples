package current.addresses;

public class verify-failure {
    
}
package addresses;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Address;

public class CreateAddress {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> addressParams = new HashMap<String, Object>();

        addressParams.put("street1", "UNDELIVERABLE ST");
        addressParams.put("city", "SAN FRANCISCO");
        addressParams.put("state", "CA");
        addressParams.put("zip", "94104");
        addressParams.put("country", "US");
        addressParams.put("company", "EasyPost");
        addressParams.put("phone", "415-123-4567");

        Address address = Address.create(addressParams);

        System.out.println(address);
    }
}
