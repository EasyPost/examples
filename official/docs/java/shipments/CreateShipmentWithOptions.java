package shipments;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;

import java.util.HashMap;

public class CreateShipmentWithOptions {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> toAddress = new HashMap<String, Object>();
        toAddress.put("id", "adr_...");

        HashMap<String, Object> fromAddress = new HashMap<String, Object>();
        fromAddress.put("id", "adr_...");

        HashMap<String, Object> parcel = new HashMap<String, Object>();
        parcel.put("id", "prcl_...");

        HashMap<String, Object> options = new HashMap<String, Object>();
        parcel.put("print_custom_1", "Custom label message");

        HashMap<String, Object> shipmentMap = new HashMap<String, Object>();
        shipmentMap.put("to_address", toAddress);
        shipmentMap.put("from_address", fromAddress);
        shipmentMap.put("parcel", parcel);
        shipmentMap.put("options", options);

        Shipment shipment = Shipment.create(shipmentMap);

        System.out.println(shipment);
    }
}
