package trackers;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Tracker;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> trackerMap = new HashMap<String, Object>();
        trackerMap.put("tracking_code", "EZ1000000001");
        trackerMap.put("carrier", "USPS");

        Tracker tracker = client.tracker.create(trackerMap);

        System.out.println(tracker);
    }
}
