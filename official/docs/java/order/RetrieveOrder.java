import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveOrder {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Order order = Order.retrieve("order_...");

        System.out.println(order);
    }
}
