package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.model.EstimatedDeliveryDate;
import com.easypost.service.EasyPostClient;

import java.util.List;

public class RetrieveEstimatedDeliveryDate {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Shipment shipment = client.shipment.retrieve("shp_...");
        List<EstimatedDeliveryDate> estimatedDeliveryDates = client
                .shipmentretrieveEstimatedDeliveryDate(shipment.getId(), "YYYY-MM-DD");

        System.out.println(estimatedDeliveryDates);
    }
}
