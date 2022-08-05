import com.easypost.EasyPost;

public class BuyShipment {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Shipment shipment = Shipment.retrieve("shp_...");

        Map<String, Object> buyMap = new HashMap<String, Object>();
        buyMap.put("rate", Rate.retrieve("rate_..."));
        buyMap.put("insurance", 249.99);

        shipment.buy(buyMap);

        System.out.println(shipment);
    }
}
