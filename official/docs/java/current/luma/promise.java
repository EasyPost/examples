package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.LumaInfo;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class LumaPromiseRequest {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> toAddress = new HashMap<String, Object>();
        toAddress.put("name", "Dr. Steve Brule");
        toAddress.put("street1", "5744 Silverton Ave");
        toAddress.put("city", "McKinney");
        toAddress.put("state", "TX");
        toAddress.put("zip", "75070");
        toAddress.put("country", "US");
        toAddress.put("phone", "8573875756");
        toAddress.put("email", "dr_steve_brule@gmail.com");

        HashMap<String, Object> fromAddress = new HashMap<String, Object>();
        fromAddress.put("name", "EasyPost");
        fromAddress.put("street1", "417 Montgomery Street");
        fromAddress.put("street2", "5th Floor");
        fromAddress.put("city", "San Francisco");
        fromAddress.put("state", "CA");
        fromAddress.put("zip", "94104");
        fromAddress.put("country", "US");
        fromAddress.put("phone", "4153334445");
        fromAddress.put("email", "support@easypost.com");

        HashMap<String, Object> parcel = new HashMap<String, Object>();
        parcel.put("length", 20.2);
        parcel.put("width", 10.9);
        parcel.put("height", 5.0);
        parcel.put("weight", 65.9);

        HashMap<String, Object> shipment = new HashMap<String, Object>();
        shipment.put("to_address", toAddress);
        shipment.put("from_address", fromAddress);
        shipment.put("parcel", parcel);
        shipment.put("ruleset_name", "test_ruleset_deliver_by_2");
        shipment.put("planned_ship_date", "2025-05-22");
        shipment.put("deliver_by_date", "2025-05-29");

        LumaInfo lumaInfo = client.luma.getPromise(shipment);
        
        System.out.println(lumaInfo);
    }
}
