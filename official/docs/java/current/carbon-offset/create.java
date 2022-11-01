package carbon_offset;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;

import java.util.HashMap;

public class create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> toAddressHashMap = new HashMap<String, Object>();
        HashMap<String, Object> fromAddressHashMap = new HashMap<String, Object>();
        HashMap<String, Object> parcelHashMap = new HashMap<String, Object>();
        HashMap<String, Object> customsInfoHashMap = new HashMap<String, Object>();
        HashMap<String, Object> shipmentHashMap = new HashMap<String, Object>();

        shipmentHashMap.put("to_address", toAddressHashMap);
        shipmentHashMap.put("from_address", fromAddressHashMap);
        shipmentHashMap.put("parcel", parcelHashMap);
        shipmentHashMap.put("customs_info", customsInfoHashMap);

        Shipment shipment = Shipment.create(shipmentHashMap, true);

        System.out.println(shipment);
    }
}
