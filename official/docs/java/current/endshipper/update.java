package endshipper;

import com.easypost.model.EndShipper;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Update {
    public static void main(String[] args) {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

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

        EndShipper updatedEndShipper = client.endShipper.update(updateParams, "es_...");

        System.out.println(updatedEndShipper);
    }
}
