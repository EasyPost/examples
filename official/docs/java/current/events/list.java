package events;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Event;
import com.easypost.model.EventCollection;

import java.util.HashMap;

public class RetrieveEventList {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<>();

        params.put("page_size", 5);

        EventCollection events = Event.all(params);

        System.out.println(events);
    }
}
