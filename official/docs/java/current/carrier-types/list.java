package carrier_types;

import com.easypost.exception.EasyPostException;
import com.easypost.model.CarrierType;
import com.easypost.service.EasyPostClient;

import java.util.List;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        List<CarrierType> carrierTypes = client.carrierType.all();

        System.out.println(carrierTypes);
    }
}
