import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveCustomsItems {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        CustomsItem customsItem = CustomsItem.retrieve("cstitem_...");

        System.out.println(customsItem);
    }
}
