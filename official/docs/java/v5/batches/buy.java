package batches;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;

public class Buy {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        Batch batch = Batch.retrieve("batch_...");

        batch.buy();

        System.out.println(batch);
    }
}
