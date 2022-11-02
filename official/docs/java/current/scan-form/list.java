package shipments;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.ScanForm;
import com.easypost.model.ScanFormCollection;

import java.util.HashMap;

public class List {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> indexMap = new HashMap<String, Object>();
        indexMap.put("page_size", 2);
        ScanFormCollection scanForms = ScanForm.all(indexMap);

        System.out.println(scanForms);
    }
}
