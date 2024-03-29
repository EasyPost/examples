package order;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Order;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

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

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("to_address", toAddress);
        params.put("from_address", fromAddress);
        params.put("shipments", parcels);

        Order order = client.order.create(params);

        System.out.println(order);
    }
}
