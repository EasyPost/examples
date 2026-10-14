package insurances;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Insurance;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> toAddressMap = new HashMap<String, Object>();
        toAddressMap.put("id", "adr_...");

        HashMap<String, Object> fromAddressMap = new HashMap<String, Object>();
        fromAddressMap.put("id", "adr_...");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("to_address", toAddressMap);
        params.put("from_address", fromAddressMap);
        params.put("tracking_code", "9400110898825022579493");
        params.put("carrier", "USPS");
        params.put("amount", "100.00");
        params.put("reference", "InsuranceRef1");

        Insurance insurance = client.insurance.create(params);

        System.out.println(insurance);
    }
}
