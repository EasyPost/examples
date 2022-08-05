import com.easypost.EasyPost;

public class RemoveShipmentFromBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Batch batch = Batch.retrieve("batch_...");

        List<Map<String, Object>> shipments = new ArrayList<Map<String, Object>>();
        Map<String, Object> shipment1 = new HashMap<String, Object>();
        shipment1.put("id", "shp_...");

        shipments.add(shipment1);

        Map<String, Object> batchMap = new HashMap<String, Object>();
        batchMap.put("shipments", shipments);

        batch.removeShipments(batchMap);

        System.out.println(batch);
    }
}
