import com.easypost.EasyPost;

public class RefundShipment {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Shipment shipment = Shipment.retrieve("shp_...");

        shipment.refund();

        System.out.println(shipment);
    }
}
