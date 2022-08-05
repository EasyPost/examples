import com.easypost.EasyPost;

public class RetrieveEvent {
    public static void main(String[] args) {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");
        
        Event event = Event.retrieve("evt_...");

        System.out.println(event);
    }
}
