package claims;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ClaimCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<>();
        params.put("page_size", 5);

        ClaimCollection claims = client.claim.all(params);

        System.out.println(claims);
    }
}
