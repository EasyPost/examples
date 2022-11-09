package getting_started;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class BuyShipmentResponse {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        // Print PNG link
        System.out.println(shipment.postage_label.label_url);
        // Print Tracking Code
        System.out.println(shipment.tracking_code);
    }
}
