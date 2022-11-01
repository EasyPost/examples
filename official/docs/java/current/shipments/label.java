package shipments;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;

import java.util.HashMap;

public class Label {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Shipment shipment = Shipment.retrieve("shp_...");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("file_format", "ZPL");

        shipment.label(params);

        System.out.println(shipment);
    }
}
