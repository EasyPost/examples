import com.easypost.EasyPost;
import java.util.*;

public class RetrieveTrackerList {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> listParams = new HashMap<>();
        listParams.put("page_size", 5);

        TrackerCollection trackers = Tracker.all(listParams);

        System.out.println(trackers);
    }
}
