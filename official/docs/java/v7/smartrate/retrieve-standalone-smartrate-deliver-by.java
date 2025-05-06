package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.EstimateDeliveryDateForZipPairResult;
import com.easypost.service.EasyPostClient;

import java.util.Collections;
import java.util.HashMap;
import java.util.Map;

public class RetrieveRecommendShipDate {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");
        Map<String, Object> params = new HashMap<String, Object>();
        params.put("from_zip", "10001");
        params.put("to_zip", "10002");
        params.put("planned_ship_date", "2024-07-18");
        params.put("carriers", Collections.singletonList("UPS"));
        
        EstimateDeliveryDateForZipPairResult results = client.smartRate
                .estimateDeliveryDate(params);

        System.out.println(results);
    }
}
