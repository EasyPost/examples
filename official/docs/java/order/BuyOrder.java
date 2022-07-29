import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class BuyOrder {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Order order = Order.retrieve("order_...");

        Map<String, Object> buyParams = new HashMap<String, Object>();
        buyParams.put("carrier", "FedEx");
        buyParams.put("service", "FEDEX_GROUND");

        order.buy(buyParams);

        System.out.println(order);
    }
}
