import com.easypost.EasyPostClient;
import com.easypost.model.Shipment;

public class OneCallLumaBuy {
    public static void main(String[] args) throws Exception {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");
        Shipment shipment = client.shipment.create(
            Map.of(
                "to_address", Map.of(
                    "name", "Dr. Steve Brule",
                    "street1", "5744 Silverton Ave",
                    "city", "McKinney",
                    "state", "TX",
                    "zip", "75070",
                    "country", "US",
                    "phone", "8573875756",
                    "email", "dr_steve_brule@gmail.com"
                ),
                "from_address", Map.of(
                    "name", "EasyPost",
                    "street1", "417 Montgomery Street",
                    "street2", "5th Floor",
                    "city", "San Francisco",
                    "state", "CA",
                    "zip", "94104",
                    "country", "US",
                    "phone", "4153334445",
                    "email", "support@easypost.com"
                ),
                "parcel", Map.of(
                    "length", 20.2,
                    "width", 10.9,
                    "height", 5,
                    "weight", 65.9
                ),
                "carrier_accounts", List.of("ca_1", "ca_2"),
                "persist_label", true,
                "ruleset_name", "required_deliver_by_date",
                "planned_ship_date", "2025-05-14",
                "deliver_by_date", "2025-05-16",
                "insurance", "50.00"
            )
        );
        System.out.println(shipment);
    }
}
