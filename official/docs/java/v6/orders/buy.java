package order;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Order;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Buy {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("carrier", "FedEx");
        params.put("service", "FEDEX_GROUND");

        Order order = client.order.buy("order_...", params);

        System.out.println(order);
    }
}
