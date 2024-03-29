package trackers;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Tracker;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("tracking_code", "EZ1000000001");
        params.put("carrier", "USPS");

        Tracker tracker = client.tracker.create(params);

        System.out.println(tracker);
    }
}
