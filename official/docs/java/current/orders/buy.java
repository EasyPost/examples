package order;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Order;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Buy {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> buyParams = new HashMap<String, Object>();
        buyParams.put("carrier", "FedEx");
        buyParams.put("service", "FEDEX_GROUND");

        Order order = client.order.buy("order_...", buyParams);

        System.out.println(order);
    }
}
