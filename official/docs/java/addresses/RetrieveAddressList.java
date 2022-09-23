package addresses;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Address;
import com.easypost.model.AddressCollection;

import java.util.HashMap;

public class RetrieveAddressList {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<>();

        params.put("page_size", 5);

        AddressCollection addresses = Address.all(params);

        System.out.println(addresses);
    }
}
