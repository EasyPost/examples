package embeddables;

import java.util.HashMap;

import com.easypost.exception.EasyPostException;
import com.easypost.model.EmbeddablesSession;
import com.easypost.service.EasyPostClient;

public class Session {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<>();
        params.put("origin_host", "https://example.com");
        params.put("user_id", "user_...");

        EmbeddablesSession session = client.embeddable.createSession(params);

        System.out.println(session);
    }
}
