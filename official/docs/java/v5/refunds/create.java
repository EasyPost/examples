package shipments;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        Shipment shipment = Shipment.retrieve("shp_...");

        shipment.refund();

        System.out.println(shipment);
    }
}
