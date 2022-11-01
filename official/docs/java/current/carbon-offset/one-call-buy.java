package carbon_offset;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;

import java.util.HashMap;

public class OneCallBuy {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> toAddressMap = new HashMap<String, Object>();
        HashMap<String, Object> fromAddressMap = new HashMap<String, Object>();
        HashMap<String, Object> parcelMap = new HashMap<String, Object>();
        HashMap<String, Object> shipmentMap = new HashMap<String, Object>();

        shipmentMap.put("carrier_accounts", "ca_...");
        shipmentMap.put("service", "NextDayAir");
        shipmentMap.put("to_address", toAddressMap);
        shipmentMap.put("from_address", fromAddressMap);
        shipmentMap.put("parcel", parcelMap);

        Shipment shipment = Shipment.create(shipmentMap, true);

        System.out.println(shipment);
    }
}
