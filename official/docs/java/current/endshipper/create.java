package endshipper;

import com.easypost.model.EndShipper;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<String, Object>();

        params.put("name", "FOO BAR");
        params.put("company", "BAZ");
        params.put("street1", "164 TOWNSEND STREET UNIT 1");
        params.put("street2", "UNIT 1");
        params.put("city", "SAN FRANCISCO");
        params.put("state", "CA");
        params.put("zip", "94107");
        params.put("country", "US");
        params.put("phone", "555-555-5555");
        params.put("email", "FOO@EXAMPLE.COM");

        EndShipper endShipper = client.endShipper.create(params);

        System.out.println(endShipper);
    }
}
