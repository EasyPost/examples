import com.easypost.EasyPost;
import java.util.*;

public class OneCallBuyOrder {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> toAddress = new HashMap<String, Object>();
        toAddress.put("id", "adr_...");

        Map<String, Object> fromAddress = new HashMap<String, Object>();
        fromAddress.put("id", "adr_...");

        Map<String, Object> firstParcel = new HashMap<String, Object>();
        firstParcel.put("weight", 10.2);

        Map<String, Object> secondParcel = new HashMap<String, Object>();
        secondParcel.put("weight", 17.5);
        secondParcel.put("predefined_package", "FedExBox");

        ArrayList<Shipment> shipments = new ArrayList<Shipment>();
        shipments.add(firstParcel);
        shipments.add(secondParcel);

        Map<String, Object> orderHash = new HashMap<String, Object>();
        orderHash.put("carrier_accounts", "ca_...");
        orderHash.put("service", "NextDayAir");
        orderHash.put("to_address", toAddress);
        orderHash.put("from_address", fromAddress);
        orderHash.put("shipments", shipments);

        Order order = Order.create(orderHash);

        System.out.println(order);
    }
}
