package trackers;

import com.easypost.exception.EasyPostException;
import com.easypost.model.TrackerCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> listParams = new HashMap<>();
        listParams.put("page_size", 5);

        TrackerCollection trackers = client.tracker.all(listParams);

        System.out.println(trackers);
    }
}
