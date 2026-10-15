package users;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.User;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        HashMap<String, Object> userMap = new HashMap<String, Object>();
        userMap.put("name", "Child Account Name");

        User user = User.create(userMap);

        System.out.println(user);
    }
}
