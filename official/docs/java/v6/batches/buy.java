package batches;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;
import com.easypost.service.EasyPostClient;

public class Buy {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Batch batch = client.batch.buy("batch_...");

        System.out.println(batch);
    }
}
