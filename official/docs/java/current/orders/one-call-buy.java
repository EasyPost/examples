package order;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Order;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;

public class OneCallBuy {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> toAddress = new HashMap<String, Object>();
        toAddress.put("id", "adr_...");

        HashMap<String, Object> fromAddress = new HashMap<String, Object>();
        fromAddress.put("id", "adr_...");

        HashMap<String, Object> firstParcel = new HashMap<String, Object>();
        firstParcel.put("weight", 10.2);

        HashMap<String, Object> secondParcel = new HashMap<String, Object>();
        secondParcel.put("weight", 17.5);
        secondParcel.put("predefined_package", "FedExBox");

        ArrayList<HashMap<String, Object>> shipments = new ArrayList<HashMap<String, Object>>();
        shipments.add(firstParcel);
        shipments.add(secondParcel);

        HashMap<String, Object> orderHash = new HashMap<String, Object>();
        orderHash.put("carrier_accounts", "ca_...");
        orderHash.put("service", "NextDayAir");
        orderHash.put("to_address", toAddress);
        orderHash.put("from_address", fromAddress);
        orderHash.put("shipments", shipments);

        Order order = client.order.create(orderHash);

        System.out.println(order);
    }
}
