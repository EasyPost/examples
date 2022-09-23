package customs_items;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.CustomsItem;

public class RetrieveCustomsItems {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        CustomsItem customsItem = CustomsItem.retrieve("cstitem_...");

        System.out.println(customsItem);
    }
}
