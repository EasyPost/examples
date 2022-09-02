import com.easypost.EasyPost;
import java.util.*;

public class ManifestBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Batch batch = Batch.retrieve("batch_...");

        batch.createScanForm();

        System.out.println(batch);
    }
}
