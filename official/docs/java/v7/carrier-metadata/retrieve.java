package carrier_metadata;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierAccount;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.List;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        // Request all metadata for all carriers
        CarrierAccount carrierMetadata = client.carrierMetadata.retrieve();
        System.out.println(carrierMetadata);

        // Request specific metadata for specific carriers
        List<String> carriers = new ArrayList<String>();
        carriers.add("usps");

        List<String> types = new ArrayList<String>();
        types.add("service_levels");
        types.add("predefined_packages");

        CarrierAccount carrierMetadata = client.carrierMetadata.retrieve(carriers, types);
        System.out.println(carrierMetadata);
    }
}
