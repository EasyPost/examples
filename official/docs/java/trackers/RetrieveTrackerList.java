import com.easypost.EasyPost;

public class RetrieveTrackerList {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Map<String, Object> listParams = new HashMap<>();
        list_params.put("page_size", 5);

        TrackerCollection trackers = Tracker.all(list_params);

        System.out.println(trackers);
    }
}
