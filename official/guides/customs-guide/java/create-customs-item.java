package customs;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreateCustomsItem {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Map<String, Object> customsItemMap = new HashMap<String, Object>();
        customsItemMap.put("description", "T-shirt");
        customsItemMap.put("quantity", 1);
        customsItemMap.put("value", 11);
        customsItemMap.put("weight", 6);
        customsItemMap.put("origin_country", "US");
        customsItemMap.put("hs_tariff_number", "610910");

        CustomsItem customsItem1 = CustomsItem.create(customsItemMap);
    }
}
