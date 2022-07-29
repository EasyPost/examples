import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveBatchList {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Map<String, Object> params = new HashMap<>();
        params.put("page_size", 5);

        BatchCollection batches = Batch.all(params);

        List<Batch> batchesList = batches.getBatches();

        System.out.println(batchesList);
    }
}
