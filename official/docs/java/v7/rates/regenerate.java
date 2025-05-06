package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

public class Regenerate {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Shipment shipment = client.shipment.newRates("shp_...");

        System.out.println(shipment);
    }
}
