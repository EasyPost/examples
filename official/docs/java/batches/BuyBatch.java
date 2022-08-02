import com.easypost.EasyPost;

public class BuyBatch {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Batch batch = Batch.retrieve("batch_...");

        batch.buy();

        System.out.println(batch);
    }
}
