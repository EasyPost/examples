package billing;

import com.easypost.exception.EasyPostException;
import com.easypost.model.PaymentMethod;
import com.easypost.service.EasyPostClient;

public class Fund {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        client.billing.fundWallet("2000", PaymentMethod.Priority.PRIMARY);
    }
}
