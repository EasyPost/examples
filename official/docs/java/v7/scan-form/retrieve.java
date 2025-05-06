package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ScanForm;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        ScanForm scanForm = client.scanform.retrieve("sf_...");

        System.out.println(scanForm);
    }
}
