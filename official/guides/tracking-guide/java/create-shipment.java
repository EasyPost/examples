package tracking_guide;

import java.util.HashMap;

import com.easypost.service.EasyPostClient;
import com.easypost.exception.EasyPostException;

public class CreateShipment {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> fromAddressMap = new HashMap<String, Object>();
        fromAddressMap.put("company", "EasyPost");
        fromAddressMap.put("street1", "417 Montgomery Street");
        fromAddressMap.put("street2", "5th Floor");
        fromAddressMap.put("city", "San Francisco");
        fromAddressMap.put("state", "CA");
        fromAddressMap.put("zip", "94104");
        fromAddressMap.put("phone", "415-528-7555");

        HashMap<String, Object> toAddressMap = new HashMap<String, Object>();
        toAddressMap.put("name", "George Costanza");
        toAddressMap.put("company", "Vandelay Industries");
        toAddressMap.put("street1", "1 E 161st St.");
        toAddressMap.put("city", "Bronx");
        toAddressMap.put("state", "NY");
        toAddressMap.put("zip", "10451");

        HashMap<String, Object> parcelMap = new HashMap<String, Object>();
        parcelMap.put("height", 9);
        parcelMap.put("width", 6);
        parcelMap.put("length", 2);
        parcelMap.put("weight", 10);

        Map<String, Object> shipmentMap = new HashMap<String, Object>();
        shipmentMap.put("to_address", toAddressMap);
        shipmentMap.put("from_address", fromAddressMap);
        shipmentMap.put("parcel", parcelMap);

        Shipment shipment = client.shipment.create(shipmentMap);

        client.Shipment.buy(shipment.getId(), shipment.lowestRate());
    }
}
