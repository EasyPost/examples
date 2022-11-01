package trackers;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Tracker;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Tracker tracker = Tracker.retrieve("trk_...");

        System.out.println(tracker);
    }
}
