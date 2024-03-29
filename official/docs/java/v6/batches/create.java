package batches;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        List<HashMap<String, Object>> shipmentsList = new ArrayList<HashMap<String, Object>>();
        HashMap<String, Object> shipmentMap = new HashMap<String, Object>();

        shipmentMap.put("id", "shp_...");

        shipmentsList.add(shipmentMap);

        HashMap<String, Object> params = new HashMap<String, Object>();

        params.put("shipment", shipmentsList);

        Batch batch = client.batch.create(params);

        System.out.println(batch);
    }
}
