import com.easypost.EasyPost;

public class InsureShipment {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Shipment purchasedShipment = Shipment.retrieve("shp_...");
        Map<String, Object> insureMap = new HashMap<String, Object>();
        insureMap.put("amount", 100);
        purchasedShipment = purchasedShipment.insure(insureMap);

        System.out.println(purchasedShipment);
    }
}
