import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Batch batch = Batch.retrieve("batch_...");
    }
}
