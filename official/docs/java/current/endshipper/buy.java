package endshipper;

import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Buy {
    public static void main(String[] args) {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Shipment shipment = client.shipment.retrieve("shp_...");

        HashMap<String, Object> buyMap = new HashMap<String, Object>();
        buyMap.put("rate", shipment.lowestRate());
        buyMap.put("end_shipper_id", "es_...");

        Shipment endshipperShipment = client.shipment.buy("shp_...", buyMap);

        System.out.println(endshipperShipment);
    }
}
