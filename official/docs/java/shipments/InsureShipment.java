import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class InsureShipment {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Shipment purchasedShipment = Shipment.retrieve("shp_...");
        Map<String, Object> insureMap = new HashMap<String, Object>();
        insureMap.put("amount", 100);
        purchasedShipment = purchasedShipment.insure(insureMap);

        System.out.println(shipment);
    }
}
