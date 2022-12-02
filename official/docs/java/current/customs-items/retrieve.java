package customs_items;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CustomsItem;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        CustomsItem customsItem = client.customsItem.retrieve("cstitem_...");

        System.out.println(customsItem);
    }
}
