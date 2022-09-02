import com.easypost.EasyPost;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class CreateBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        List<HashMap<String, Object>> shipmentsList = new ArrayList<HashMap<String, Object>>();
        HashMap<String, Object> shipmentMap = new HashMap<String, Object>();

        shipmentMap.put("id", "shp_...");

        shipmentsList.add(shipmentMap);

        HashMap<String, Object> batchMap = new HashMap<String, Object>();

        batchMap.put("shipment", shipmentsList);

        Batch batch = Batch.create(batchMap);

        System.out.println(batch);
    }
}
