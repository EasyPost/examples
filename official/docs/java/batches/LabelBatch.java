import com.easypost.EasyPost;
import java.util.*;

public class LabelBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Batch batch = Batch.retrieve("batch_...");

        Map<String, Object> labelMap = new HashMap<String, Object>();
        labelMap.put("file_format", "PDF");

        batch.label(labelMap);

        System.out.println(batch);
    }
}
