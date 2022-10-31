package current.scan-form;

public class list {

}

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

EasyPost.apiKey="<YOUR_TEST/PRODUCTION_API_KEY>";

Map<String, Object> indexMap = new HashMap<String, Object>();indexMap.put("page_size",2);
ScanFormCollection scanForms = ScanForm.all(indexMap);
