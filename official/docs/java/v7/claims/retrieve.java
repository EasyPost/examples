package claims;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Claim;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Claim claim = client.claim.retrieve("clm_...");

        System.out.println(claim);
    }
}
