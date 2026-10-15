package shipments;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;

import java.util.HashMap;

public class Insure {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        Shipment purchasedShipment = Shipment.retrieve("shp_...");

        HashMap<String, Object> insureMap = new HashMap<String, Object>();
        insureMap.put("amount", 100);

        purchasedShipment = purchasedShipment.insure(insureMap);

        System.out.println(purchasedShipment);
    }
}
