package order;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Order;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        Order order = Order.retrieve("order_...");

        System.out.println(order);
    }
}
