package users;

import com.easypost.exception.EasyPostException;
import com.easypost.model.User;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> userMap = new HashMap<String, Object>();
        userMap.put("name", "Child Account Name");

        User user = client.user.create(userMap);

        System.out.println(user);
    }
}
