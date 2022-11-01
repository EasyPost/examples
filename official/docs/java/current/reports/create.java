package reports;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Report;

import java.util.HashMap;

public class Create {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        HashMap<String, Object> reportMap = new HashMap<String, Object>();
        reportMap.put("type", "payment_log");
        reportMap.put("start_date", "2022-10-01");
        reportMap.put("end_date", "2022-10-31");

        Report report = Report.create(reportMap);

        System.out.println(report);
    }
}
