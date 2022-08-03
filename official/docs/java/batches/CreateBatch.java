import com.easypost.EasyPost;

public class CreateBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> shipmentMap = new HashMap<String, Object>();
        shipmentMap.put("id", "shp_...");

        shipmentsList.add(shipmentMap);

        Map<String, Object> batchMap = new HashMap<String, Object>();
        batchMap.put("shipment", shipmentsList);
        Batch batch = Batch.create(batchMap);

        System.out.println(batch);
    }
}
