package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ScanForm;
import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Shipment shipment = client.shipment.retrieve("shp_...");

        List<Shipment> shipments = new ArrayList<Shipment>();
        shipments.add(shipment);

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("shipments", shipments);

        ScanForm scanForm = client.scanform.create(params);

        System.out.println(scanForm);
    }
}
