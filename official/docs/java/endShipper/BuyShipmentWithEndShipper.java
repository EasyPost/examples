import com.easypost.EasyPost;
import java.util.HashMap;

public class BuyShipmentWithEndShipper {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Shipment shipment = Shipment.retrieve("shp_...");

        HashMap<String, Object> buyMap = new HashMap<String, Object>();
        buyMap.put("rate", shipment.lowestRate());
        buyMap.put("end_shipper_id", "es_...");

        shipment.buy(buyMap);

        System.out.println(shipment);
    }
}
