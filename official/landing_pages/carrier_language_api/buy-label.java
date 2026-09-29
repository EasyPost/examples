package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.model.Parcel;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Buy {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));
        Parcel parcel = client.parcel.create(new HashMap<string, object>() {
            {
                put("predefined_package", "Parcel");
                put("weight", 28);
            }
        });

        Shipment shipment = client.shipment.create(new HashMap<string, object>() {
            {
                put("to_address", toAddress);
                put("from_address", fromAddress);
                put("parcel", parcel);
            }
        });

        client.shipment.buy(shipment.getId(), shipment.lowestRate());
    }
}
