import com.easypost.EasyPost;

public class ManifestBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Batch batch = Batch.retrieve("batch_...");

        batch.createScanForm();

        System.out.println(batch);
    }
}
