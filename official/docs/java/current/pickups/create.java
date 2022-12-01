package pickups;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Pickup;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> address = new HashMap<String, Object>();
        address.put("id", "adr_...");

        HashMap<String, Object> shipment = new HashMap<String, Object>();
        shipment.put("id", "shp_...");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("address", address);
        params.put("shipment", shipment);
        params.put("reference", "my-first-pickup");
        params.put("min_datetime", "2022-10-01 10:30:00");
        params.put("max_datetime", "2022-10-02 10:30:00");
        params.put("is_account_address", false);
        params.put("instructions", "Special pickup instructions");

        Pickup pickup = client.pickup.create(params);

        System.out.println(pickup);
    }
}
