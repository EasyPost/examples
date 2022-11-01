package order;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Order;

import java.util.HashMap;

public class Buy {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Order order = Order.retrieve("order_...");

        HashMap<String, Object> buyParams = new HashMap<String, Object>();
        buyParams.put("carrier", "FedEx");
        buyParams.put("service", "FEDEX_GROUND");

        order.buy(buyParams);

        System.out.println(order);
    }
}
