package getting_started;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreateToAddress {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Map<String, Object> toAddressMap = new HashMap<String, Object>();
        addressMap.put("name", "George Costanza");
        addressMap.put("company", "Vandelay Industries");
        addressMap.put("street1", "1 E 161st St.");
        addressMap.put("city", "Bronx");
        addressMap.put("state", "NY");
        addressMap.put("zip", "10451");

        Address.create(toAddressMap);
    }
}
