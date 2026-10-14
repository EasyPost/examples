package users;

import com.easypost.exception.EasyPostException;
import com.easypost.model.User;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        // Retrieve the authenticated user
        User parentUser = client.user.retrieveMe();

        System.out.println(parentUser);

        // Retrieve a child user
        User childUser = client.user.retrieve("user_...");

        System.out.println(childUser);
    }
}
