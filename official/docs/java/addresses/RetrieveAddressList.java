import com.easypost.EasyPost;
import java.util.*;

public class RetrieveAddressList {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> params = new HashMap<>();

        listParams.put("page_size", 5);

        AddressCollection addresses = Address.all(listParams);

        System.out.println(addresses);
    }
}
