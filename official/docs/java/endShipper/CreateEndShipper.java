import com.easypost.EasyPost;

public class CreateEndShipper {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Map<String, Object> endShipperData = new HashMap<String, Object>();

        endShipperData.put("name", "FOO BAR");
        endShipperData.put("company", "BAZ");
        endShipperData.put("street1", "164 TOWNSEND STREET UNIT 1");
        endShipperData.put("street2", "UNIT 1");
        endShipperData.put("city", "SAN FRANCISCO");
        endShipperData.put("state", "CA");
        endShipperData.put("zip", "94107");
        endShipperData.put("country", "US");
        endShipperData.put("phone", "555-555-5555");
        endShipperData.put("email", "FOO@EXAMPLE.COM");

        EndShipper endShipper = EndShipper.create(endShipperData);

        System.out.println(endShipper);
    }
}
