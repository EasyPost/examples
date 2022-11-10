package customs;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreateInternationalShipment {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Map<String, Object> toAddress = new HashMap<String, Object>();
        toAddress.put("name", "Tim Canterbury");
        toAddress.put("company", "Wernham Hogg");
        toAddress.put("street1", "118 Clippenham Lane");
        toAddress.put("city", "Slough");
        toAddress.put("country", "GB");
        toAddress.put("zip", "SL15BE");

        Map<String, Object> fromAddress = new HashMap<String, Object>();
        toAddress.put("company", "EasyPost");
        toAddress.put("street1", "417 Montgomery Street");
        toAddress.put("street2", "5th Floor");
        toAddress.put("city", "San Francisco");
        toAddress.put("state", "CA");
        toAddress.put("country", "US");
        toAddress.put("zip", "94104");

        Map<String, Object> parcel = new HashMap<String, Object>();
        parcel.put("height", 3);
        parcel.put("width", 6);
        parcel.put("length", 9);
        parcel.put("weight", 20);

        Map<String, Object> shipment = new HashMap<String, Object>();
        shipment.put("to_address", toAddress);
        shipment.put("from_address", fromAddress);
        shipment.put("parcel", parcel);
        shipment.put("customs_info", customs_info);

        Shipment.create(shipment);
    }
}
