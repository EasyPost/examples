package batches;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;

import java.util.HashMap;

public class LabelBatch {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Batch batch = Batch.retrieve("batch_...");

        HashMap<String, Object> labelMap = new HashMap<String, Object>();
        labelMap.put("file_format", "PDF");

        batch.label(labelMap);

        System.out.println(batch);
    }
}
