import com.easypost.EasyPost;
import java.util.HashMap;

public class BuyOrder {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Order order = Order.retrieve("order_...");

        HashMap<String, Object> buyParams = new HashMap<String, Object>();
        buyParams.put("carrier", "FedEx");
        buyParams.put("service", "FEDEX_GROUND");

        order.buy(buyParams);

        System.out.println(order);
    }
}
