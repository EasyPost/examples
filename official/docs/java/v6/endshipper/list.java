package endshipper;

import com.easypost.model.EndShipperCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<>();
        params.put("page_size", 5);

        EndShipperCollection endShippers = client.endShipper.all(params);

        System.out.println(endShippers);
    }
}
