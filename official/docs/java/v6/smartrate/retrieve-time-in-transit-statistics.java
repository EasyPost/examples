package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.SmartRate;
import com.easypost.service.EasyPostClient;

import java.util.List;

public class RetrieveTimeInTransitStatistics {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        List<SmartRate> smartrates = client.shipment.smartrates("shp_...");

        System.out.println(smartrates);
    }
}
