package insurances;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Insurance;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Insurance insurance = client.insurance.refund("ins_...");

        System.out.println(insurance);
    }
}
