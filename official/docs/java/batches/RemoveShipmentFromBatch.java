import com.easypost.EasyPost;
import java.util.*;

public class RemoveShipmentFromBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Batch batch = Batch.retrieve("batch_...");

        Map<String, Object> shipment1 = new HashMap<String, Object>();
        shipment1.put("id", "shp_...");

        List<Map<String, Object>> shipments = new ArrayList<Map<String, Object>>();
        shipments.add(shipment1);

        Map<String, Object> batchMap = new HashMap<String, Object>();
        batchMap.put("shipments", shipments);

        batch.removeShipments(batchMap);

        System.out.println(batch);
    }
}
