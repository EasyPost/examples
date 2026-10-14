package brand;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.User;
import com.easypost.model.Brand;

import java.util.HashMap;

public class Update {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        User user = User.retrieveMe();

        HashMap<String, Object> params = new HashMap<>();
        params.put("color", "303F9F");

        Brand brand = user.updateBrand(params);

        System.out.println(brand);
    }
}
