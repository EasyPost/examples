import com.easypost.EasyPost;

public class RetrieveApiKeys {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        ApiKeys parentKeys = ApiKeys.all();

        System.out.println(parentKeys);
    }
}
