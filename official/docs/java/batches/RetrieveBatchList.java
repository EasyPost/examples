import com.easypost.EasyPost;
import java.util.HashMap;

public class RetrieveBatchList {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        HashMap<String, Object> params = new HashMap<>();
        params.put("page_size", 5);

        BatchCollection batches = Batch.all(params);

        System.out.println(batches);
    }
}
