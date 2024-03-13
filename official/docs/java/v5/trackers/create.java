package trackers;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Tracker;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        HashMap<String, Object> trackerMap = new HashMap<String, Object>();
        trackerMap.put("tracking_code", "EZ1000000001");
        trackerMap.put("carrier", "USPS");

        Tracker tracker = Tracker.create(trackerMap);

        System.out.println(tracker);
    }
}
