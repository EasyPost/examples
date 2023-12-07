package endshipper;

import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Buy {
    public static void main(String[] args) {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Shipment shipment = client.shipment.retrieve("shp_...");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("rate", shipment.lowestRate());
        params.put("end_shipper_id", "es_...");

        Shipment endShipper = client.shipment.buy(shipment.getId(), params);

        System.out.println(endShipper);
    }
}
