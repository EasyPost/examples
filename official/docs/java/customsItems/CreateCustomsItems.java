import com.easypost.EasyPost;
import java.util.HashMap;

public class CreateCustomsItems {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        HashMap<String, Object> customsItemMap = new HashMap<String, Object>();
        customsItemMap.put("description", "T-shirt");
        customsItemMap.put("quantity", 1);
        customsItemMap.put("value", 10);
        customsItemMap.put("weight", 5);
        customsItemMap.put("origin_country", "US");
        customsItemMap.put("hs_tariff_number", "123456");

        CustomsItem customsItem = CustomsItem.create(customsItemMap);

        System.out.println(customsItem);
    }
}
