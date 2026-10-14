package api_keys;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.ApiKeys;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        ApiKeys parentKeys = ApiKeys.all();

        System.out.println(parentKeys);
    }
}
