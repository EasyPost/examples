package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.model.RecommendShipDateForShipmentResult;
import com.easypost.service.EasyPostClient;

import java.util.List;

public class RetrieveRecommendShipDate {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Shipment shipment = client.shipment.retrieve("shp_...");
        List<RecommendShipDateForShipmentResult> rates = client.shipment
                .recommendShipDate(shipment.getId(), "YYYY-MM-DD");

        System.out.println(rates);
    }
}
