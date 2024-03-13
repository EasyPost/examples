package events;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Payload;
import com.easypost.service.EasyPostClient;

public class RetrievePayload {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Payload payload = client.event.retrievePayload("evt_...", "payload_...");

        System.out.println(payload);
    }
}
