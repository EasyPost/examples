import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RetrieveEvent {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Event event = Event.retrieve("evt_...");
        
        System.out.println(events); 
    }
}
