package addresses;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Address;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Address address = client.address.retrieve("adr_...");

        System.out.println(address);
    }
}
