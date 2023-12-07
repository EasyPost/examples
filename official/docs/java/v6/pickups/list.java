package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.PickupCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<>();
        params.put("page_size", 5);

        PickupCollection pickupCollection = client.pickup.all(params);

        System.out.println(pickupCollection);
    }
}
