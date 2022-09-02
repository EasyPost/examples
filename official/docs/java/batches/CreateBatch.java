import com.easypost.EasyPost;
import java.util.*;

public class CreateBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        List<Map<String, Object>> shipmentsList = new ArrayList<Map<String, Object>>();
        Map<String, Object> shipmentMap = new HashMap<String, Object>();
        
        shipmentMap.put("id", "shp_...");

        shipmentsList.add(shipmentMap);

        Map<String, Object> batchMap = new HashMap<String, Object>();
        
        batchMap.put("shipment", shipmentsList);

        Batch batch = Batch.create(batchMap);

        System.out.println(batch);
    }
}
