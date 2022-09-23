import com.easypost.EasyPost;
import java.util.HashMap;

public class UpdateEndShipper {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        EndShipper endShipper = EndShipper.retrieve("es_...");

        HashMap<String, Object> updateParams = new HashMap<String, Object>();

        updateParams.put("name", "NEW NAME");
        updateParams.put("company", "BAZ");
        updateParams.put("street1", "164 TOWNSEND STREET UNIT 1");
        updateParams.put("street2", "UNIT 1");
        updateParams.put("city", "SAN FRANCISCO");
        updateParams.put("state", "CA");
        updateParams.put("zip", "94107");
        updateParams.put("country", "US");
        updateParams.put("phone", "555-555-5555");
        updateParams.put("email", "FOO@EXAMPLE.COM");

        EndShipper updatedEndShipper = endShipper.update(updateParams);

        System.out.println(updatedEndShipper);
    }
}
