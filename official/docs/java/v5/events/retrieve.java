package events;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Event;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        Event event = Event.retrieve("evt_...");

        System.out.println(event);
    }
}
