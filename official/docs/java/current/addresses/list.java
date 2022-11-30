package addresses;

import com.easypost.exception.EasyPostException;
import com.easypost.model.AddressCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<>();

        params.put("page_size", 5);

        AddressCollection addresses = client.address.all(params);

        System.out.println(addresses);
    }
}
