import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveShipmentList {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> list_params = new HashMap<>();
        list_params.put("page_size", 5);

        ShipmentCollection shipments = Shipment.all(list_params);

        System.out.println(shipment);
    }
}
