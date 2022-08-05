import com.easypost.EasyPost;

public class RetrieveCustomsItems {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        CustomsItem customsItem = CustomsItem.retrieve("cstitem_...");

        System.out.println(customsItem);
    }
}
