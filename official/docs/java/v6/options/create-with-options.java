package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class CreateWithOptions {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> toAddress = new HashMap<String, Object>();
        toAddress.put("id", "adr_...");

        HashMap<String, Object> fromAddress = new HashMap<String, Object>();
        fromAddress.put("id", "adr_...");

        HashMap<String, Object> parcel = new HashMap<String, Object>();
        parcel.put("id", "prcl_...");

        HashMap<String, Object> options = new HashMap<String, Object>();
        parcel.put("print_custom_1", "Custom label message");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("to_address", toAddress);
        params.put("from_address", fromAddress);
        params.put("parcel", parcel);
        params.put("options", options);

        Shipment shipment = client.shipment.create(params);

        System.out.println(shipment);
    }
}
