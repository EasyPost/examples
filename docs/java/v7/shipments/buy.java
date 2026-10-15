package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Buy {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Shipment retrievedShipment = client.shipment.retrieve("shp_...");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("rate", retrievedShipment.lowestRate());
        params.put("insurance", "249.99");

        Shipment shipment = client.shipment.buy(retrievedShipment.getId(), params);

        System.out.println(shipment);
    }
}
