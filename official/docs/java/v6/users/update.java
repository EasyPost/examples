package users;

import com.easypost.exception.EasyPostException;
import com.easypost.model.User;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Update {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("recharge_threshold", "50.00");

        User user = client.user.update("user_...", params);

        System.out.println(user);
    }
}
