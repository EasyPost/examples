import com.easypost.EasyPost;

public class RetrieveOrder {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Order order = Order.retrieve("order_...");

        System.out.println(order);
    }
}
