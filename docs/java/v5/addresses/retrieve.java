package addresses;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Address;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        Address address = Address.retrieve("adr_...");

        System.out.println(address);
    }
}
