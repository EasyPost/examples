package batches;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Label {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> labelMap = new HashMap<String, Object>();
        labelMap.put("file_format", "PDF");

        Batch batch = client.batch.label("batch_...", labelMap);

        System.out.println(batch);
    }
}
