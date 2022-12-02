package shipments;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.ScanForm;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        ScanForm scanForm = ScanForm.retrieve("sf_...");

        System.out.println(scanForm);
    }
}
