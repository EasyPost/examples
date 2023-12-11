package trackers;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Tracker;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Tracker tracker = client.tracker.retrieve("trk_...");

        System.out.println(tracker);
    }
}
