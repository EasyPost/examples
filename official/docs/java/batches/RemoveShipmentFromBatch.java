import com.easypost.EasyPost;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class RemoveShipmentFromBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Batch batch = Batch.retrieve("batch_...");

        HashMap<String, Object> shipment1 = new HashMap<String, Object>();
        shipment1.put("id", "shp_...");

        List<HashMap<String, Object>> shipments = new ArrayList<HashMap<String, Object>>();
        shipments.add(shipment1);

        HashMap<String, Object> batchMap = new HashMap<String, Object>();
        batchMap.put("shipments", shipments);

        batch.removeShipments(batchMap);

        System.out.println(batch);
    }
}
