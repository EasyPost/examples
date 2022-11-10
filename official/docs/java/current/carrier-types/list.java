package carrier_types;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierType;

import java.util.List;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        List<CarrierType> carrierTypes = CarrierType.all();

        System.out.println(carrierTypes);
    }
}
