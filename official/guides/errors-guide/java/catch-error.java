package errors;

import java.util.HashMap;

import com.easypost.service.EasyPostClient;
import com.easypost.exception.APIException;

public class CatchError {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        try {
            Map<String, Object> addressData = new HashMap<String, Object>();

            addressData.put("verify_strict", true);

            Address address = client.address.create(address);
        } catch (APIException error) {
            System.err.println(error.getCode());
        }
    }
}
