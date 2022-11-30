package batches;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class AddShipments {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> shipment1 = new HashMap<String, Object>();
        shipment1.put("id", "shp_...");

        HashMap<String, Object> shipment2 = new HashMap<String, Object>();
        shipment2.put("id", "shp_...");

        List<HashMap<String, Object>> shipments = new ArrayList<HashMap<String, Object>>();
        shipments.add(shipment1);
        shipments.add(shipment2);

        HashMap<String, Object> batchMap = new HashMap<String, Object>();
        batchMap.put("shipments", shipments);

        Batch batchWithShipment = client.batch.addShipments("batch_...", batchMap);

        System.out.println(batchWithShipment);
    }
}
