package endshipper;

import com.easypost.model.EndShipper;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        EndShipper endShipper = client.endShipper.retrieve("es_...");

        System.out.println(endShipper);
    }
}
