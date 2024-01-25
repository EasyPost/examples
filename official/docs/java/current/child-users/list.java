package users;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ChildUserCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class AllChildren {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<>();

        params.put("page_size", 5);

        ChildUserCollection childUsers = client.users.allChildren(params);

        System.out.println(childUsers);
    }
}
