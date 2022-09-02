import com.easypost.EasyPost;
import java.util.*;

public class RetrieveShipmentList {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> listParams = new HashMap<>();
        listParams.put("page_size", 5);

        ShipmentCollection shipments = Shipment.all(listParams);

        System.out.println(shipments);
    }
}
