package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class CreateAndBuyLuma {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> toAddressMap = new HashMap<String, Object>();
        toAddressMap.put("name", "Dr. Steve Brule");
        toAddressMap.put("street1", "5744 Silverton Ave");
        toAddressMap.put("city", "McKinney");
        toAddressMap.put("state", "TX");
        toAddressMap.put("zip", "75070");
        toAddressMap.put("country", "US");
        toAddressMap.put("phone", "8573875756");
        toAddressMap.put("email", "dr_steve_brule@gmail.com");

        HashMap<String, Object> fromAddressMap = new HashMap<String, Object>();
        fromAddressMap.put("name", "EasyPost");
        fromAddressMap.put("street1", "417 Montgomery Street");
        fromAddressMap.put("street2", "5th Floor");
        fromAddressMap.put("city", "San Francisco");
        fromAddressMap.put("state", "CA");
        fromAddressMap.put("zip", "94104");
        fromAddressMap.put("country", "US");
        fromAddressMap.put("phone", "4153334445");
        fromAddressMap.put("email", "support@easypost.com");

        HashMap<String, Object> parcelMap = new HashMap<String, Object>();
        parcelMap.put("length", 20.2);
        parcelMap.put("width", 10.9);
        parcelMap.put("height", 5);
        parcelMap.put("weight", 65.9);

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("to_address", toAddressMap);
        params.put("from_address", fromAddressMap);
        params.put("parcel", parcelMap);
        params.put("carrier_accounts", new String[] {"ca_b96417366e094ef68a5207bb2dd4d518"});
        params.put("persist_label", true);
        params.put("ruleset_name", "required_deliver_by_date");
        params.put("planned_ship_date", "2025-07-18");
        params.put("deliver_by_date", "2025-07-20");
        params.put("insurance", "50.00");
        
        Shipment shipment = client.shipment.createLuma(params);
        
        System.out.println(shipment);
    }
}
