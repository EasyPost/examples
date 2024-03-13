import com.easypost.EasyPost;

public class Retrieve {
    public static void main(String[] args) {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        EndShipper retrievedEndShipper = EndShipper.retrieve("es_...");

        System.out.println(retrievedEndShipper);
    }
}
