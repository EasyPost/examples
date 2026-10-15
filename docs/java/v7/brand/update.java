package brand;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Brand;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class Update {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        HashMap<String, Object> params = new HashMap<>();
        params.put("color", "303F9F");

        Brand brand = client.user.updateBrand("user_...", params);

        System.out.println(brand);
    }
}
