package referral;

import com.easypost.exception.EasyPostException;
import com.easypost.model.BetaPaymentRefund;
import com.easypost.service.EasyPostClient;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        BetaPaymentRefund refund = client.refundByPaymentLog.refundByAmount(2000);

        System.out.println(refund);
    }
}
