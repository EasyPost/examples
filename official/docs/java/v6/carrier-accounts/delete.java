package carrier_accounts;

import com.easypost.exception.EasyPostException;
import com.easypost.service.EasyPostClient;

public class Delete {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        client.carrierAccount.delete("ca_...");
    }
}
