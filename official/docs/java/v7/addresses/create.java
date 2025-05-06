package addresses;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Address;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();

        params.put("street1", "417 MONTGOMERY ST");
        params.put("street2", "FLOOR 5");
        params.put("city", "SAN FRANCISCO");
        params.put("state", "CA");
        params.put("zip", "94104");
        params.put("country", "US");
        params.put("company", "EasyPost");
        params.put("phone", "415-123-4567");

        Address address = client.address.create(params);

        System.out.println(address);
    }
}
