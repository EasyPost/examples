package batches;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;
import com.easypost.service.EasyPostClient;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Buy {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        List<HashMap<String, Object>> shipmentsList = new ArrayList<HashMap<String, Object>>();
        HashMap<String, Object> shipmentMap = new HashMap<String, Object>();

        HashMap<String, Object> fromAddress = new HashMap<String, Object>();
        fromAddress.put("id", "adr_...");
        shipmentMap.put("from_address", fromAddress);

        HashMap<String, Object> toAddress = new HashMap<String, Object>();
        toAddress.put("id", "adr_...");
        shipmentMap.put("to_address", toAddress);

        HashMap<String, Object> parcel = new HashMap<String, Object>();
        parcel.put("id", "prcl_...");
        shipmentMap.put("parcel", parcel);

        shipmentMap.put("service", "First");
        shipmentMap.put("carrier", "USPS");

        String[] carrierAccounts = { "ca_..." };
        shipmentMap.put("carrier_accounts", carrierAccounts);

        shipmentsList.add(shipmentMap);

        HashMap<String, Object> params = new HashMap<String, Object>();

        params.put("shipment", shipmentsList);

        Batch createdBatch = client.batch.create(params);

        Batch batch = client.batch.buy(createdBatch.getId());

        System.out.println(batch);
    }
}
