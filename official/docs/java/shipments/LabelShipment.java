import com.easypost.EasyPost;

public class LabelShipment {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Shipment shipment = Shipment.retrieve("shp_...");

        Map<String, Object> params = new HashMap<String, Object>();
        params.put("file_format", "ZPL");

        shipment.label(params);

        System.out.println(shipment);
    }
}
