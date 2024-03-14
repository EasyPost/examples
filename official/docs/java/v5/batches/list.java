package batches;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;
import com.easypost.model.BatchCollection;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        HashMap<String, Object> params = new HashMap<>();
        params.put("page_size", 5);

        BatchCollection batches = Batch.all(params);

        System.out.println(batches);
    }
}
