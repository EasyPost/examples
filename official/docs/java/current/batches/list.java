package batches;

import com.easypost.exception.EasyPostException;
import com.easypost.model.BatchCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<>();
        params.put("page_size", 5);

        BatchCollection batches = client.batch.all(params);

        System.out.println(batches);
    }
}
