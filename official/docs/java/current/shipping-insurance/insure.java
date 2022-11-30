package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Insure {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> insureMap = new HashMap<String, Object>();
        insureMap.put("amount", 100);

        Shipment shipment = client.shipment.insure("shp_...", insureMap);

        System.out.println(shipment);
    }
}
