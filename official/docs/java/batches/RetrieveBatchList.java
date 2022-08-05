import com.easypost.EasyPost;

public class RetrieveBatchList {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> params = new HashMap<>();
        params.put("page_size", 5);

        BatchCollection batches = Batch.all(params);

        System.out.println(batches);
    }
}
