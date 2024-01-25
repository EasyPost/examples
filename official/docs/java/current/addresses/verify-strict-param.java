package addresses;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Address;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class VerifyStrictParam {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<String, Object>();

        params.put("street1", "000 unknown street");
        params.put("city", "Not A City");
        params.put("state", "ZZ");
        params.put("zip", "00001");
        params.put("country", "US");
        params.put("email", "test@example.com");
        params.put("phone", "5555555555");
        params.put("verify_strict", true);

        Address address = client.address.create(params);

        System.out.println(address);
    }
}
