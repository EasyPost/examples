import com.easypost.EasyPost;

public class RetrieveSmartrate {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Shipment shipment = Shipment.retrieve("shp_...");

        shipment.getSmartrates();

        System.out.println(shipment);
    }
}
