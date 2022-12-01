package insurances;

import com.easypost.exception.EasyPostException;
import com.easypost.model.InsuranceCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<>();
        params.put("page_size", 5);

        InsuranceCollection insurances = client.insurance.all(params);

        System.out.println(insurances);
    }
}
