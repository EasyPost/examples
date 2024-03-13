package order;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Order;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Order order = client.order.retrieve("order_...");

        System.out.println(order);
    }
}
