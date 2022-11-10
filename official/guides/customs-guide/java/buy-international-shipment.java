package customs;

import java.util.HashMap;
import java.util.List;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class BuyInternationalShipment {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        List<String> buyCarriers = new ArrayList<String>();
        buyCarriers.add("USPS");
        List<String> buyServices = new ArrayList<String>();
        buyServices.add("First");
        shipment.buy(shipment.lowestRate(buyCarriers, buyServices));

        // OR

        Map<String, Object> rate = new HashMap<String, Object>();
        rate.put("id", "{RATE_ID}");
        shipment.buy(rate);

        // Print PNG link
        System.out.println(shipment.postage_label.label_url);
        // Print Tracking Code
        System.out.println(shipment.postage_label.tracking_code);
    }
}
