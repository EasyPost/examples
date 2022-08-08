import com.easypost.EasyPost;

public class RetrieveTracker {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Tracker tracker = Tracker.retrieve("trk_...");

        System.out.println(tracker);
    }
}
