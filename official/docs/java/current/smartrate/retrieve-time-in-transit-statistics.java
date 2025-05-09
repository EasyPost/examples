package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.SmartRate;
import com.easypost.service.EasyPostClient;

import java.util.List;

public class RetrieveTimeInTransitStatistics {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        List<SmartRate> smartrates = client.shipment.smartRates("shp_...");

        System.out.println(smartrates);
    }
}
