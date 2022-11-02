package shipments;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;

public class RetrieveTimeInTransitStatistics {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Shipment shipment = Shipment.retrieve("shp_...");

        shipment.smartrates();

        System.out.println(shipment);
    }
}
