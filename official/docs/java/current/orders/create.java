package order;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Order;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> toAddress = new HashMap<String, Object>();
        toAddress.put("id", "adr_...");

        HashMap<String, Object> fromAddress = new HashMap<String, Object>();
        fromAddress.put("id", "adr_...");

        HashMap<String, Object> parcel1 = new HashMap<String, Object>();
        parcel1.put("weight", 10.2);

        HashMap<String, Object> parcel2 = new HashMap<String, Object>();
        parcel2.put("weight", 17.5);
        parcel2.put("predefined_package", "FedExBox");

        ArrayList<HashMap<String, Object>> parcels = new ArrayList<HashMap<String, Object>>();
        parcels.add(parcel1);
        parcels.add(parcel2);

        HashMap<String, Object> orderMap = new HashMap<String, Object>();
        orderMap.put("to_address", toAddress);
        orderMap.put("from_address", fromAddress);
        orderMap.put("shipments", parcels);

        Order order = client.order.create(orderMap);

        System.out.println(order);
    }
}
