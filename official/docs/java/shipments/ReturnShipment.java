import com.easypost.EasyPost;

public class ReturnShipment {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> toAddressMap = new HashMap<String, Object>();
        toAddressMap.put("name", "Dr. Steve Brule");
        toAddressMap.put("street1", "179 N Harbor Dr");
        toAddressMap.put("city", "Redondo Beach");
        toAddressMap.put("state", "CA");
        toAddressMap.put("country", "US");
        toAddressMap.put("phone", "8573875756");
        toAddressMap.put("email", "dr_steve_brule@gmail.com");
        toAddressMap.put("zip", "90277");

        Map<String, Object> fromAddressMap = new HashMap<String, Object>();
        fromAddressMap.put("name", "EasyPost");
        fromAddressMap.put("street1", "417 Montgomery Street");
        fromAddressMap.put("street2", "5th Floor");
        fromAddressMap.put("city", "San Francisco");
        fromAddressMap.put("state", "CA");
        fromAddressMap.put("zip", "94104");
        fromAddressMap.put("country", "US");
        fromAddressMap.put("phone", "4153334445");
        fromAddressMap.put("email", "support@easypost.com");

        Map<String, Object> parcelMap = new HashMap<String, Object>();
        parcelMap.put("length", 20.2);
        parcelMap.put("width", 10.9);
        parcelMap.put("height", 5);
        parcelMap.put("weight", 65.9);

        Map<String, Object> shipmentMap = new HashMap<String, Object>();
        shipmentMap.put("to_address", toAddressMap);
        shipmentMap.put("from_address", fromAddressMap);
        shipmentMap.put("parcel", parcelMap);
        shipmentMap.put("is_return", "true");

        Shipment shipment = Shipment.create(shipmentMap);

        System.out.println(shipment);
    }
}
