package events;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Event;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Event event = client.event.retrieve("evt_...");

        System.out.println(event);
    }
}
