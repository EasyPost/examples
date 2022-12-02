package brand;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Brand;
import com.easypost.model.User;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Update {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        User user = User.retrieveMe();

        HashMap<String, Object> params = new HashMap<>();
        params.put("color", "303F9F");

        Brand brand = client.user.updateBrand(user.getId(), params);

        System.out.println(brand);
    }
}
