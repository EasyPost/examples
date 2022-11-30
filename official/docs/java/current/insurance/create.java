package insurances;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Insurance;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> toAddressMap = new HashMap<String, Object>();
        toAddressMap.put("id", "adr_...");

        HashMap<String, Object> fromAddressMap = new HashMap<String, Object>();
        fromAddressMap.put("id", "adr_...");

        HashMap<String, Object> insuranceMap = new HashMap<String, Object>();
        insuranceMap.put("to_address", toAddressMap);
        insuranceMap.put("from_address", fromAddressMap);
        insuranceMap.put("tracking_code", "9400110898825022579493");
        insuranceMap.put("carrier", "USPS");
        insuranceMap.put("amount", "100.00");
        insuranceMap.put("reference", "InsuranceRef1");

        Insurance insurance = client.insurance.create(insuranceMap);

        System.out.println(insurance);
    }
}
