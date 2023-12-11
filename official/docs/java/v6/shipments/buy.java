package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Buy {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Shipment shipment = client.shipment.retrieve("shp_...");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("rate", shipment.lowestRate());
        params.put("insurance", "249.99");

        Shipment boughtShipment = client.shipment.buy(shipment.getId(), params);

        System.out.println(boughtShipment);
    }
}
