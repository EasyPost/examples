package refunds;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Refund;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("carrier", toAddressMap);
        params.put("tracking_codes", Arrays.asList(new String[] { "EZ1000000001" }));

        List<Refund> refunds = client.refund.create(params);

        System.out.println(refunds);
    }
}
