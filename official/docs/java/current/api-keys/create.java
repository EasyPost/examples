package api_keys;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ApiKey;
import com.easypost.service.EasyPostClient;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        ApiKey apiKey = client.apiKey.create("test");

        System.out.println(apiKey);
    }
}
