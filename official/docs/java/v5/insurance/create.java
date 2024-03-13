package insurances;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Insurance;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

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

        Insurance insurance = Insurance.create(insuranceMap);

        System.out.println(insurance);
    }
}
