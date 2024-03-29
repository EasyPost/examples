package order;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Order;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;

public class OneCallBuy {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

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

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("carrier_accounts", "ca_...");
        params.put("service", "NextDayAir");
        params.put("to_address", toAddress);
        params.put("from_address", fromAddress);
        params.put("shipments", shipments);

        Order order = client.order.create(params);

        System.out.println(order);
    }
}
