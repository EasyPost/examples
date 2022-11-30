package users;

import com.easypost.exception.EasyPostException;
import com.easypost.service.EasyPostClient;

public class Delete {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        client.user.delete("user_...");
    }
}
