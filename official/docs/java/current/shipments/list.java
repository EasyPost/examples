package shipments;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.model.ShipmentCollection;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> listParams = new HashMap<>();
        listParams.put("page_size", 5);

        ShipmentCollection shipments = Shipment.all(listParams);

        System.out.println(shipments);
    }
}
