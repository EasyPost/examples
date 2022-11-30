package endshipper;

import com.easypost.model.EndShipper;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        EndShipper retrievedEndShipper = client.endShipper.retrieve("es_...");

        System.out.println(retrievedEndShipper);
    }
}
