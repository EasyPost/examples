package trackers;

import java.util.Arrays;
import java.util.HashMap;

import com.easypost.exception.EasyPostException;
import com.easypost.model.TrackerCollection;
import com.easypost.service.EasyPostClient;

public class Batch {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("tracking_codes", Arrays.asList("EZ1000000001", "EZ1000000002"));

        TrackerCollection trackers = client.tracker.retrieveBatch(params);

        System.out.println(trackers);
    }
}
