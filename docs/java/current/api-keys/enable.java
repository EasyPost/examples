package api_keys;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ApiKey;
import com.easypost.service.EasyPostClient;

public class Enable {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        ApiKey apiKey = client.apiKey.enable("ak_...");

        System.out.println(apiKey);
    }
}
