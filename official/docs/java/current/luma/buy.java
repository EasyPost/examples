package luma;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class BuyLuma {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");
        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("ruleset_name", "ruleset_name");
        params.put("planned_ship_date", "2025-05-14");
        params.put("deliver_by_date", "2025-05-16");

        Shipment shipment = client.shipment.luma("shp_...", params);

        System.out.println(shipment);
    }
}
