package getting_started;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CreateTracker {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        // Creating a Tracker
        Map<String, Object> params = new HashMap<String, Object>();
        params.put("tracking_code", "EZ4000000004");
        params.put("carrier", "UPS");
        Tracker tracker = Tracker.create(params);
    }
}
