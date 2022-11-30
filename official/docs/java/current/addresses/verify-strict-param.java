package addresses;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Address;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class VerifyStrictParam {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> addressParams = new HashMap<String, Object>();

        addressParams.put("street1", "417 Montgomery Street");
        addressParams.put("city", "SF");
        addressParams.put("state", "CA");
        addressParams.put("zip", "94104");
        addressParams.put("country", "US");
        addressParams.put("company", "EasyPost");
        addressParams.put("phone", "415-123-4567");
        addressParams.put("verify_strict", true);

        Address address = client.address.create(addressParams);

        System.out.println(address);
    }
}
