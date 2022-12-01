package addresses;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Address;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class VerifyStrictParam {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<String, Object>();

        params.put("street1", "417 Montgomery Street");
        params.put("city", "SF");
        params.put("state", "CA");
        params.put("zip", "94104");
        params.put("country", "US");
        params.put("company", "EasyPost");
        params.put("phone", "415-123-4567");
        params.put("verify_strict", true);

        Address address = client.address.create(params);

        System.out.println(address);
    }
}
