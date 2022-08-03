import com.easypost.EasyPost;

public class RetrieveShipment {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Shipment shipment = Shipment.retrieve("shp_...");

        System.out.println(shipment);
    }
}
