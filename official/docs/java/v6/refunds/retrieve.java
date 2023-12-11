package refunds;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Refund;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        Refund refund = client.refund.retrieve("rfnd_...");

        System.out.println(refund);
    }
}
