package batches;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        List<HashMap<String, Object>> shipmentsList = new ArrayList<HashMap<String, Object>>();
        HashMap<String, Object> shipmentMap = new HashMap<String, Object>();

        shipmentMap.put("id", "shp_...");

        shipmentsList.add(shipmentMap);

        HashMap<String, Object> batchMap = new HashMap<String, Object>();

        batchMap.put("shipment", shipmentsList);

        Batch batch = client.batch.create(batchMap);

        System.out.println(batch);
    }
}
