package customs_info;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.CustomsInfo;
import com.easypost.model.CustomsItem;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        HashMap<String, Object> customsItemMap = new HashMap<String, Object>();
        customsItemMap.put("description", "T-shirt");
        customsItemMap.put("quantity", 1);
        customsItemMap.put("value", 10);
        customsItemMap.put("weight", 5);
        customsItemMap.put("origin_country", "us");
        customsItemMap.put("hs_tariff_number", "123456");

        CustomsItem customsItem1 = CustomsItem.create(customsItemMap);

        List<CustomsItem> customsItemsList = new ArrayList<CustomsItem>();
        customsItemsList.add(customsItem1);

        HashMap<String, Object> customsInfoMap = new HashMap<String, Object>();
        customsInfoMap.put("customs_certify", true);
        customsInfoMap.put("customs_signer", "Steve Brule");
        customsInfoMap.put("contents_type", "merchandise");
        customsInfoMap.put("contents_explanation", "");
        customsInfoMap.put("eel_pfc", "NOEEI 30.37(a)");
        customsInfoMap.put("restriction_type", "none");
        customsInfoMap.put("customs_items", customsItemsList);

        CustomsInfo customsInfo = CustomsInfo.create(customsInfoMap);

        System.out.println(customsInfo);
    }
}
