package users;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.User;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        // Retrieve the authenticated user
        User user = User.retrieveMe();

        // Retrieve a child user
        User user = User.retrieve("user_...");

        System.out.println(user);
    }
}
