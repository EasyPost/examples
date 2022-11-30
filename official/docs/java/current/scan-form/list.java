package shipments;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ScanFormCollection;
import com.easypost.service.EasyPostClient;

import java.util.HashMap;

public class All {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        HashMap<String, Object> indexMap = new HashMap<String, Object>();
        indexMap.put("page_size", 2);
        ScanFormCollection scanForms = client.scanform.all(indexMap);

        System.out.println(scanForms);
    }
}
