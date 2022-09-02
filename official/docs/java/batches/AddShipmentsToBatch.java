import com.easypost.EasyPost;
import java.util.*;

public class AddShipmentsToBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> shipment1 = new HashMap<String, Object>();
        shipment1.put("id", "shp_...");

        Map<String, Object> shipment2 = new HashMap<String, Object>();
        shipment2.put("id", "shp_...");

        List<Map<String, Object>> shipments = new ArrayList<Map<String, Object>>();
        shipments.add(shipment1);
        shipments.add(shipment2);

        Map<String, Object> batchMap = new HashMap<String, Object>();
        batchMap.put("shipments", shipments);

        Batch batch = Batch.retrieve("batch_...");
        batch.addShipments(batchMap);

        System.out.println(batch);
    }
}
