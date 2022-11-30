package customs_items;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CustomsItem;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> customsItemMap = new HashMap<String, Object>();
        customsItemMap.put("description", "T-shirt");
        customsItemMap.put("quantity", 1);
        customsItemMap.put("value", 10);
        customsItemMap.put("weight", 5);
        customsItemMap.put("origin_country", "US");
        customsItemMap.put("hs_tariff_number", "123456");

        CustomsItem customsItem = client.customsItem.create(customsItemMap);

        System.out.println(customsItem);
    }
}
