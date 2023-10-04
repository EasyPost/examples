package api_keys;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ApiKeys;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        // Retrieve all API keys including children
        ApiKeys parentKeys = client.apiKey.all();

        System.out.println(parentKeys);

        // Retrieve API keys for a specific child user
        ApiKeys childKeys = client.apiKey.retrieveApiKeysForUser("user_...");

        System.out.println(childKeys);
    }
}
