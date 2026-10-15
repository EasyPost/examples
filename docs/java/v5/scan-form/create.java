package shipments;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Shipment;
import com.easypost.model.ScanForm;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        List<Shipment> shipments = new ArrayList<Shipment>();
        shipments.add(shipments);

        HashMap<String, Object> paramMap = new HashMap<String, Object>();
        paramMap.put("shipments", shipments);

        ScanForm scanForm = ScanForm.create(paramMap);

        System.out.println(scanForm);
    }
}
