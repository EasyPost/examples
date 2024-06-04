package getting_started;

import com.easypost.service.EasyPostClient;
import com.easypost.exception.EasyPostException;

public class PrintShipmentTrackingCode {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        // Print Tracking Code
        System.out.println(shipment.postage_label.tracking_code);
    }
}
