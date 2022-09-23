package users;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.User;

public class UpdateChildUser {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("name", "Test Child");

        User user = User.retrieveMe();

        user.update(params);

        System.out.println(user);
    }
}
