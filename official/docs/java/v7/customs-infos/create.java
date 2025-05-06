package customs_info;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CustomsInfo;
import com.easypost.model.CustomsItem;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> customsItemMap = new HashMap<String, Object>();
        customsItemMap.put("description", "T-shirt");
        customsItemMap.put("quantity", 1);
        customsItemMap.put("value", 10);
        customsItemMap.put("weight", 5);
        customsItemMap.put("origin_country", "us");
        customsItemMap.put("hs_tariff_number", "123456");

        CustomsItem customsItem = client.customsItem.create(customsItemMap);

        List<CustomsItem> customsItemsList = new ArrayList<CustomsItem>();
        customsItemsList.add(customsItem);

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("customs_certify", true);
        params.put("customs_signer", "Steve Brule");
        params.put("contents_type", "merchandise");
        params.put("contents_explanation", "");
        params.put("eel_pfc", "NOEEI 30.37(a)");
        params.put("restriction_type", "none");
        params.put("customs_items", customsItemsList);

        CustomsInfo customsInfo = client.customsInfo.create(params);

        System.out.println(customsInfo);
    }
}
