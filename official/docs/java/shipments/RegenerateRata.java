import com.easypost.EasyPost;

public class RegenerateRata {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Shipment shipment = Shipment.retrieve("shp_...");

        shipment = shipment.newRates();

        System.out.println(shipment);
    }
}
