package customs_items;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CustomsItem;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("description", "T-shirt");
        params.put("quantity", 1);
        params.put("value", 10);
        params.put("weight", 5);
        params.put("origin_country", "US");
        params.put("hs_tariff_number", "123456");

        CustomsItem customsItem = client.customsItem.create(params);

        System.out.println(customsItem);
    }
}
