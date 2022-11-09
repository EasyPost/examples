package getting_started;

import java.util.HashMap;
import java.util.List;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class BuyShipment {
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
    }
}
