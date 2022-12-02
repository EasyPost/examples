package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ScanFormCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> params = new HashMap<String, Object>();
        params.put("page_size", 5);

        ScanFormCollection scanForms = client.scanform.all(params);

        System.out.println(scanForms);
    }
}
