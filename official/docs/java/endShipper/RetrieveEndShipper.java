import com.easypost.EasyPost;

public class RetrieveEndShipper {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        EndShipper retrievedEndShipper = EndShipper.retrieve("es_...");

        System.out.println(retrievedEndShipper);
    }
}
