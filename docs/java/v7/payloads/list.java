package events;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Payload;
import com.easypost.service.EasyPostClient;

public class RetrieveAllPayloads {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        List<Payload> payloads = client.event.retrieveAllPayloads("evt_...");

        System.out.println(payloads);
    }
}
