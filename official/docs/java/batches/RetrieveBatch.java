import com.easypost.EasyPost;

public class RetrieveBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Batch batch = Batch.retrieve("batch_...");

        System.out.println(batch);
    }
}
