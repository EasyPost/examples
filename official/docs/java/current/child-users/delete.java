package users;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.User;

public class Delete {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        User user = User.retrieve("user_...");

        user.delete();

        System.out.println(user);
    }
}
