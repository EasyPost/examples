import com.easypost.EasyPost;
import java.util.HashMap;
import java.util.List;

public class CreateOrder {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        HashMap<String, Object> toAddress = new HashMap<String, Object>();
        toAddress.put("id", "adr_...");

        HashMap<String, Object> fromAddress = new HashMap<String, Object>();
        fromAddress.put("id", "adr_...");

        HashMap<String, Object> parcel1 = new HashMap<String, Object>();
        parcel1.put("weight", 10.2);

        HashMap<String, Object> parcel2 = new HashMap<String, Object>();
        parcel2.put("weight", 17.5);
        parcel2.put("predefined_package", "FedExBox");

        List<Parcel> parcelList = parcelList.add(parcel1);
        parcelList.add(parcel2);

        HashMap<String, Object> orderMap = new HashMap<String, Object>();
        orderMap.put("to_address", toAddress);
        orderMap.put("from_address", fromAddress);
        orderMap.put("shipments", parcelList);

        Order order = Order.create(orderMap);

        System.out.println(order);
    }
}
