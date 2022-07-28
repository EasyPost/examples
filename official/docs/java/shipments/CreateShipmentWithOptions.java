import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreateShipmentWithOptions {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        HashMap<String, Object> toAddress = new HashMap<String, Object>();
        toAddress.put("id", "adr_...");
        
        HashMap<String, Object> fromAddress = new HashMap<String, Object>();
        fromAddress.put("id", "adr_...");
        
        HashMap<String, Object> parcel = new HashMap<String, Object>();
        parcel.put("id", "prcl_...");

        HashMap<String, Object> options = new HashMap<String, Object>();
        parcel.put("address_validation_level", 0);
        
        HashMap<String, Object> shipmentMap = new HashMap<String, Object>();
        shipmentMap.put("to_address", toAddress);
        shipmentMap.put("from_address", fromAddress);
        shipmentMap.put("parcel", parcel);
        shipmentMap.put("options", options);
        
        Shipment shipment = Shipment.create(shipmentMap);

        System.out.println(shipment);
    }
}
