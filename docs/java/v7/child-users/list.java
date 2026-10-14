package child_users;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ChildUserCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class List {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<>();

        params.put("page_size", 5);

        ChildUserCollection childUsers = client.user.allChildren(params);

        System.out.println(childUsers);
    }
}
